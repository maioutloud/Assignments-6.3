namespace Assignments_6._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnq = new System.Windows.Forms.Button();
            this.dataCustomer = new System.Windows.Forms.DataGridView();
            this.btnDeq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnq
            // 
            this.btnEnq.AccessibleDescription = "en";
            this.btnEnq.BackColor = System.Drawing.Color.Red;
            this.btnEnq.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnq.ForeColor = System.Drawing.Color.Snow;
            this.btnEnq.Location = new System.Drawing.Point(51, 265);
            this.btnEnq.Name = "btnEnq";
            this.btnEnq.Size = new System.Drawing.Size(261, 61);
            this.btnEnq.TabIndex = 1;
            this.btnEnq.Text = "HOLD";
            this.btnEnq.UseVisualStyleBackColor = false;
            this.btnEnq.Visible = false;
            this.btnEnq.Click += new System.EventHandler(this.btnEnq_Click);
            // 
            // dataCustomer
            // 
            this.dataCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCustomer.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomer.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataCustomer.Location = new System.Drawing.Point(334, 120);
            this.dataCustomer.Name = "dataCustomer";
            this.dataCustomer.RowHeadersWidth = 51;
            this.dataCustomer.RowTemplate.Height = 24;
            this.dataCustomer.Size = new System.Drawing.Size(486, 416);
            this.dataCustomer.TabIndex = 2;
            // 
            // btnDeq
            // 
            this.btnDeq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeq.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeq.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeq.Location = new System.Drawing.Point(51, 357);
            this.btnDeq.Name = "btnDeq";
            this.btnDeq.Size = new System.Drawing.Size(261, 61);
            this.btnDeq.TabIndex = 3;
            this.btnDeq.Text = "RETURN CALL";
            this.btnDeq.UseVisualStyleBackColor = false;
            this.btnDeq.Click += new System.EventHandler(this.btnDeq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "CUSTOMER CALL MANAGEMENT SYSTEM";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtName.Location = new System.Drawing.Point(51, 205);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 36);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Enter Name";
            this.txtName.Visible = false;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleDescription = "en";
            this.btnShow.AutoSize = true;
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Red;
            this.btnShow.Location = new System.Drawing.Point(51, 120);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(261, 61);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "INCOMING CALL";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Font = new System.Drawing.Font("Roboto Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(51, 475);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(252, 61);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "EXIT";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeq);
            this.Controls.Add(this.dataCustomer);
            this.Controls.Add(this.btnEnq);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaint Hotline";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnq;
        private System.Windows.Forms.Button btnDeq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.DataGridView dataCustomer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Timer timer1;
    }
}

