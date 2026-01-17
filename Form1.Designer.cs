namespace RemoteWorkApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.txtKpp = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblInn = new System.Windows.Forms.Label();
            this.lblKpp = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRemote = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // Настройка TextBox и Label
            this.txtOrgName.Location = new System.Drawing.Point(190, 30); this.txtOrgName.Name = "txtOrgName"; this.txtOrgName.Size = new System.Drawing.Size(350, 20);
            this.txtInn.Location = new System.Drawing.Point(190, 70); this.txtInn.Name = "txtInn"; this.txtInn.Size = new System.Drawing.Size(150, 20);
            this.txtKpp.Location = new System.Drawing.Point(190, 110); this.txtKpp.Name = "txtKpp"; this.txtKpp.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.Location = new System.Drawing.Point(190, 150); this.txtTotal.Name = "txtTotal"; this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtRemote.Location = new System.Drawing.Point(190, 190); this.txtRemote.Name = "txtRemote"; this.txtRemote.Size = new System.Drawing.Size(100, 20);
            this.dtpStart.Location = new System.Drawing.Point(190, 230); this.dtpStart.Name = "dtpStart";
            this.dtpEnd.Location = new System.Drawing.Point(190, 270); this.dtpEnd.Name = "dtpEnd";
            // Кнопки
            this.btnLoad.Location = new System.Drawing.Point(190, 320); this.btnLoad.Name = "btnLoad"; this.btnLoad.Size = new System.Drawing.Size(120, 40); this.btnLoad.Text = "Загрузить";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnSave.Location = new System.Drawing.Point(330, 320); this.btnSave.Name = "btnSave"; this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // Подписи
            this.lblOrg.Text = "Организация:"; this.lblOrg.Location = new System.Drawing.Point(30, 33);
            this.lblInn.Text = "ИНН:"; this.lblInn.Location = new System.Drawing.Point(30, 73);
            this.lblKpp.Text = "КПП:"; this.lblKpp.Location = new System.Drawing.Point(30, 113);
            this.lblTotal.Text = "Сотрудников:"; this.lblTotal.Location = new System.Drawing.Point(30, 153);
            this.lblRemote.Text = "Дистанционно:"; this.lblRemote.Location = new System.Drawing.Point(30, 193);
            // Форма
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtOrgName, this.txtInn, this.txtKpp, this.txtTotal, this.txtRemote,
                this.dtpStart, this.dtpEnd, this.btnLoad, this.btnSave,
                this.lblOrg, this.lblInn, this.lblKpp, this.lblTotal, this.lblRemote
            });
            this.Text = "Отчет по приказу №24";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.TextBox txtKpp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblInn;
        private System.Windows.Forms.Label lblKpp;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
    }
}