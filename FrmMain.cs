using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace grit
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            fnRefreshResources = new RefreshResourcesDelegate(ListResources_Refresh);
        }

        #region refresh resources

        Dictionary<UInt16, byte[]> resources = new Dictionary<ushort, byte[]>();

        delegate void RefreshResourcesDelegate();
        RefreshResourcesDelegate fnRefreshResources = null;

        public void ListResources_Refresh()
        {
            ListResources.Items.Clear();
            foreach (var resource in resources)
            {
                var lvi = ListResources.Items.Add(resource.Key.ToString());
                lvi.SubItems.Add(Encoding.UTF8.GetString(resource.Value));
            }

            statusNOR.Text = string.Format("共有{0}条记录", ListResources.Items.Count);
        }

        public void RefreshResources()
        {
            if (ListResources.InvokeRequired)
            {
                ListResources.Invoke(fnRefreshResources);
            }
            else
            {
                ListResources_Refresh();
            }
        }

        #endregion

        const uint PACK_FILE_VERSION = 4;

        const int HEADER_LENGTH = 2 * 4 + 1;

        const int ENTRITY_SIZE = 2 + 4;

        const byte BINARY = 0;
        const byte UTF8 = 1;
        const byte UTF16 = 2;

        Dictionary<UInt16, byte[]> LoadFromFile(string filename)
        {
            var resources = new Dictionary<UInt16, byte[]>();

            var pak_data = File.ReadAllBytes(filename);

            var pak_offset = 0;
            var pak_head = pak_data.Skip(pak_offset).Take(HEADER_LENGTH).ToArray();
            pak_offset += HEADER_LENGTH;

            var version_number = BitConverter.ToUInt32(pak_head, 0);
            var number_of_resources = BitConverter.ToUInt32(pak_head, 4);
            var encoding = pak_head.Last<byte>();

            if (number_of_resources > 0)
            {
                var pak_entrity = new byte[ENTRITY_SIZE];
                for (var i = 0; i < number_of_resources; i++)
                {
                    pak_entrity = pak_data.Skip(pak_offset).Take(ENTRITY_SIZE).ToArray();
                    pak_offset += ENTRITY_SIZE;

                    var id = BitConverter.ToUInt16(pak_entrity, 0);
                    var offset = BitConverter.ToUInt32(pak_entrity, 2);

                    pak_entrity = pak_data.Skip(pak_offset).Take(ENTRITY_SIZE).ToArray();
                    var next_id = BitConverter.ToUInt16(pak_entrity, 0);
                    var next_offset = BitConverter.ToUInt32(pak_entrity, 2);

                    resources[id] = pak_data.Skip((int)offset).Take((int)(next_offset - offset)).ToArray();
                }
            }

            return resources;
        }

        void SaveToFile(string filepath, Dictionary<UInt16, byte[]> resources)
        {
            var pak_head = new List<byte>();
            pak_head.AddRange(BitConverter.GetBytes(PACK_FILE_VERSION));
            pak_head.AddRange(BitConverter.GetBytes(resources.Count));
            pak_head.Add(UTF8);

            var offset = HEADER_LENGTH + resources.Count * ENTRITY_SIZE + ENTRITY_SIZE;
            var pak_entries = new List<byte>();
            foreach (var resource in resources)
            {
                pak_entries.AddRange(BitConverter.GetBytes(resource.Key));
                pak_entries.AddRange(BitConverter.GetBytes(offset));
                offset += resource.Value.Length;
            }
            UInt16 end_id = 0;
            pak_entries.AddRange(BitConverter.GetBytes(end_id));
            pak_entries.AddRange(BitConverter.GetBytes(offset));

            var pak_content = new List<byte>();
            foreach (var resource in resources)
            {
                pak_content.AddRange(resource.Value);
            }

            var pak_data = new List<byte>();
            pak_data.AddRange(pak_head);
            pak_data.AddRange(pak_entries);
            pak_data.AddRange(pak_content);

            File.WriteAllBytes(filepath, pak_data.ToArray());
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            var dr = DlgOpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                resources = LoadFromFile(DlgOpenFile.FileName);

                RefreshResources();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            var dr = DlgSaveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                SaveToFile(DlgSaveFile.FileName, resources);
            }
        }

        private void ListResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuMod.Enabled = ListResources.SelectedItems.Count > 0;
            mnuDel.Enabled = ListResources.SelectedItems.Count > 0;
        }
    }
}
