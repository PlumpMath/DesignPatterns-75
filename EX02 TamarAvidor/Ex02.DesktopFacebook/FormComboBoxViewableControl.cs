using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex01.DesktopFacebook
{
    public partial class FormComboBoxViewableControl : Form
    {
        public FormComboBoxViewableControl()
        {
            this.InitializeComponent();
        }

        public ComboBox ComboBox
        {
            get
            {
                return this.comboBoxViewableControls;
            }
        }

        public IViewableControl SelectedControl { get; set; }

        internal void PopulateComboBoxFromListOfControls()
        {
            this.comboBoxViewableControls.DisplayMember = "Name";
            foreach (Type type in MyControlsRepository.Instance.GetTypes())
            {
                this.comboBoxViewableControls.Items.Add(type);
            }
        }

        private void comboBoxViewableControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxViewableControls.SelectedItem != null)
            {
                Type type = this.comboBoxViewableControls.SelectedItem as Type;
                this.SelectedControl = MyControlsRepository.Instance.GetReference(type);
            }

            this.Hide();
        }
    }
}
