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
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            this.InitializeComponent();
            this.orderLabelsAtForm();
        }

        private void orderLabelsAtForm()
        {
            int x = 50;
            this.labelUsername.Location = new Point(x, x);
            this.labelFirstname.Location = new Point(x, this.labelUsername.Bottom + x);
            this.labelLastname.Location = new Point(x, this.labelFirstname.Bottom + x);
            this.labelGender.Location = new Point(x, this.labelLastname.Bottom + x);
            this.labelBirthday.Location = new Point(x, this.labelGender.Bottom + x);
            this.labelRelationshipStatus.Location = new Point(x, this.labelBirthday.Bottom + x);
            this.labelReligion.Location = new Point(x, this.labelRelationshipStatus.Bottom + x);
            this.labelEmail.Location = new Point(x, this.labelReligion.Bottom + x);
        }

        public Label LableUsername
        {
            get
            {
                return this.labelUsername;
            }
        }

        public Label LableLastname
        {
            get
            {
                return this.labelLastname;
            }
        }

        public Label LableFirstname
        {
            get
            {
                return this.labelFirstname;
            }
        }

        public Label LableGender
        {
            get
            {
                return this.labelGender;
            }
        }

        public Label LableBirthday
        {
            get
            {
                return this.labelBirthday;
            }
        }

        public Label LableRelationshipStatus
        {
            get
            {
                return this.labelRelationshipStatus;
            }
        }

        public Label LableReligion
        {
            get
            {
                return this.labelReligion;
            }
        }

        public Label LableEmail
        {
            get
            {
                return this.labelEmail;
            }
        }
    }
}
