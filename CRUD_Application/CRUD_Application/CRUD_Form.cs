using CRUD_Application.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Application
{
    public partial class CRUD_Form : MetroFramework.Forms.MetroForm
    {
        public CRUD_Form()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog())
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    ofd.Filter = "JPEG|*.jpg";
                    picBox.Image = Image.FromFile(ofd.FileName);
                    Employee obj = employeeBindingSource.Current as Employee;
                    if (obj != null)
                        obj.ImageURL = ofd.FileName;
                }
            }
        }

        private void CRUD_Form_Load(object sender, EventArgs e)
        {
            ModelContext db = new ModelContext();
            employeeBindingSource.DataSource = db.EmpList.ToList();                
            
            rightPanel.Enabled = false;
            Employee obj = employeeBindingSource.Current as Employee;
            if (obj != null)
                picBox.Image = Image.FromFile(obj.ImageURL);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            picBox.Image = null;
            rightPanel.Enabled = true;
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            nameTBox.Focus();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Enabled = true;
            nameTBox.Focus();
            Employee obj = employeeBindingSource.Current as Employee;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            rightPanel.Enabled = false;
            employeeBindingSource.ResetBindings(false);
            CRUD_Form_Load(sender,e);

        }

 

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee obj = employeeBindingSource.Current as Employee;
            if (obj != null)
                picBox.Image = Image.FromFile(obj.ImageURL);
        } 
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //if (MetroFramework.MetroMessageBox.Show(this, "Are you want to delete this Record?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            //{
            //    using (ModelContext db=new ModelContext())
            //    {
            //        Employee obj = employeeBindingSource.Current as Employee;
            //        if (obj != null)
            //            if (db.Entry<Employee>(obj).State == EntityState.Detached)
            //                db.Set<Employee>().Attach(obj);
            //        db.Entry<Employee>(obj).State = EntityState.Deleted;
            //        db.SaveChanges();
            //        MessageBox.Show("Deleted Successfully");
            //        employeeBindingSource.RemoveCurrent();
            //        rightPanel.Enabled = false;
            //        picBox.Image = null;
            //    }
            //}
        }
    }
}
