using System;
using System.Windows.Forms;

namespace FluxTool_CleanerSystem_K4
{
    public partial class ToolInfoRegistForm : Form
    {
        private int iCH;

        public ToolInfoRegistForm()
        {
            InitializeComponent();
        }

        private void ToolInfoRegistForm_Load(object sender, EventArgs e)
        {
            Top = 350;
            Left = 350;            
        }

        private void ToolInfoRegistForm_Activated(object sender, EventArgs e)
        {
            textBox_User.Focus();
        }

        public void Init(int iModule)
        {
            iCH = iModule;
            
            Define.ToolInfoRegist_User[iModule] = string.Empty;
            Define.ToolInfoRegist_Lot[iModule] = string.Empty;
            Define.ToolInfoRegist_MC[iModule] = string.Empty;
            Define.ToolInfoRegist_ToolID[iModule] = string.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(textBox_User.Text) ||
                string.IsNullOrWhiteSpace(textBox_LotNo.Text) ||
                string.IsNullOrWhiteSpace(textBox_MC.Text) ||
                string.IsNullOrWhiteSpace(textBox_ToolID.Text))
            {
                MessageBox.Show($"Tool 정보를 입력해 주세요", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {                
                Define.ToolInfoRegist_User[iCH] = textBox_User.Text.ToString();
                Define.ToolInfoRegist_Lot[iCH] = textBox_LotNo.Text.ToString();
                Define.ToolInfoRegist_MC[iCH] = textBox_MC.Text.ToString();
                Define.ToolInfoRegist_ToolID[iCH] = textBox_ToolID.Text.ToString();

                DialogResult = DialogResult.OK;

                Close();
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_LotNo.Focus();
            }
        }

        private void textBox_LotNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_MC.Focus();
            }
        }

        private void textBox_MC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_ToolID.Focus();
            }
        }
    }
}
