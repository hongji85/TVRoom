using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVRoom
{
    public partial class Form1 : Form
    {
        SessionManager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new SessionManager();
        }

        private void btnEnterTVRoom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonName.Text))
            {
                lbUsers.Items.Add(txtPersonName.Text);

                if (manager.ActiveSession != null)
                {
                    if (!manager.ActiveSession.AddUser(txtPersonName.Text))
                        MessageBox.Show("Person already exists.");
                }
                else
                {
                    manager.CreateSession().AddUser(txtPersonName.Text);
                    lbSessions.Items.Add(string.Format("Session {0} initiated", manager.ActiveSession.SessionID.ToString()));
                }

                txtPersonName.Text = "";
            }
            else
                MessageBox.Show("Person name is required.");
        }

        private void btnExitTVRoom_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItems.Count > 0)
            {
                if (manager.ActiveSession != null)
                {
                    manager.ActiveSession.RemoveUser(lbUsers.SelectedItem.ToString());
                    lbUsers.Items.Remove(lbUsers.SelectedItem);
                    if (manager.ActiveSession == null)
                        lbSessions.Items[lbSessions.Items.Count - 1] = string.Format("Session {0} ended, time on: {1} seconds", manager.LastSession.SessionID.ToString(), manager.LastSession.TotalSessionTime);
                }
            }
            else
                MessageBox.Show("Please select a person.");
        }

        private void btnCalculateTimeOn_Click(object sender, EventArgs e)
        {
            lblTimeOn.Text = string.Format("{0} seconds", manager.CalculateTimeOn);
        }
    }
}
