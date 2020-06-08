using System;
using System.Data;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class F_Func_Selectlist : Form
    {
        RightingSys.BLL.FunctionManager funcManager = new RightingSys.BLL.FunctionManager();
        System.Data.DataTable dtFuncHandle = new DataTable();
        public F_Func_Selectlist(object FuncHandle)
        {
            InitializeComponent();
            InitilControl(FuncHandle);
        }

        private void InitilControl(object FuncHandle)
        {

            dtFuncHandle = funcManager.GetFuncHandleList();
            DataColumn isSelect = new DataColumn("IsSelect", typeof(bool));
            isSelect.DefaultValue = false;
            dtFuncHandle.Columns.Add(isSelect);
            gcDate.DataSource = dtFuncHandle;


            if (FuncHandle == null)
                return;
            SetFuncHandle(Convert.ToInt32(FuncHandle.ToString()));
        }
        
        private void sbtnOK_Click(object sender, EventArgs e)
        {
            dtFuncHandle.AcceptChanges();
            DataRow[] rows = dtFuncHandle.Select("IsSelect=true");
            foreach (DataRow r in rows)
            {
                _SelectText = _SelectText + "," + r["Name"];
                _FuncHandle = _FuncHandle + int.Parse(r["HandleNo"].ToString());
            }
            base.DialogResult = DialogResult.OK;
        }

        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private string _SelectText="";
        private int _FuncHandle=0;

        public string SelectText
        {
            get
            {
                if (_SelectText.Length > 0)
                {
                    return _SelectText.Remove(0, 1);
                }
                else
                {
                    return "";
                }
            }
        }

        public int FuncHandle { get => _FuncHandle; set => _FuncHandle = value; }

        public void SetFuncHandle(int pEnum)
        {
            if ((pEnum & 1) == 1)
            {
                dtFuncHandle.Rows[0]["IsSelect"] = true;
            }
            if ((pEnum & 2) == 2)
            {
                dtFuncHandle.Rows[1]["IsSelect"] = true;
            }
            if ((pEnum & 4) == 4)
            {
                dtFuncHandle.Rows[2]["IsSelect"] = true;
            }
            if ((pEnum & 8) == 8)
            {
                dtFuncHandle.Rows[3]["IsSelect"] = true;
            }
            if ((pEnum & 16) == 16)
            {
                dtFuncHandle.Rows[4]["IsSelect"] = true;
            }
            if ((pEnum & 32) == 32)
            {
                dtFuncHandle.Rows[5]["IsSelect"] = true;
            }
            if ((pEnum & 64) == 64)
            {
                dtFuncHandle.Rows[6]["IsSelect"] = true;
            }
            if ((pEnum & 128) == 128)
            {
                dtFuncHandle.Rows[7]["IsSelect"] = true;
            }
            if ((pEnum & 256) == 256)
            {
                dtFuncHandle.Rows[8]["IsSelect"] = true;
            }
            if ((pEnum & 512) == 512)
            {
                dtFuncHandle.Rows[9]["IsSelect"] = true;
            }
            if ((pEnum & 1024) == 1024)
            {
                dtFuncHandle.Rows[10]["IsSelect"] = true;
            }
            if ((pEnum & 2048) == 2048)
            {
                dtFuncHandle.Rows[11]["IsSelect"] = true;
            }
            if ((pEnum & 4096) == 4096)
            {
                dtFuncHandle.Rows[12]["IsSelect"] = true;
            }
            if ((pEnum & 8192) == 8192)
            {
                dtFuncHandle.Rows[13]["IsSelect"] = true;
            }
            if ((pEnum & 16384) == 16384)
            {
                dtFuncHandle.Rows[14]["IsSelect"] = true;
            }
            if ((pEnum & 32768) == 32768)
            {
                dtFuncHandle.Rows[15]["IsSelect"] = true;
            }
            dtFuncHandle.AcceptChanges();
        }
    }
}
