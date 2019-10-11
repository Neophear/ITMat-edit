namespace ITMat_edit
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnSetPickedUp = new System.Windows.Forms.Button();
            this.btnSetReturned = new System.Windows.Forms.Button();
            this.statusLine = new System.Windows.Forms.StatusStrip();
            this.statusLineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutlookName = new System.Windows.Forms.TextBox();
            this.txtDatePickedUp = new System.Windows.Forms.TextBox();
            this.txtDateReturned = new System.Windows.Forms.TextBox();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.statusLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(97, 12);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(55, 20);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 15);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 13);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "Ordrenummer";
            // 
            // btnSetPickedUp
            // 
            this.btnSetPickedUp.Enabled = false;
            this.btnSetPickedUp.Location = new System.Drawing.Point(139, 64);
            this.btnSetPickedUp.Name = "btnSetPickedUp";
            this.btnSetPickedUp.Size = new System.Drawing.Size(57, 20);
            this.btnSetPickedUp.TabIndex = 5;
            this.btnSetPickedUp.Text = "Afhentet";
            this.btnSetPickedUp.UseVisualStyleBackColor = true;
            this.btnSetPickedUp.Click += new System.EventHandler(this.Button_Click);
            this.btnSetPickedUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // btnSetReturned
            // 
            this.btnSetReturned.Enabled = false;
            this.btnSetReturned.Location = new System.Drawing.Point(139, 91);
            this.btnSetReturned.Name = "btnSetReturned";
            this.btnSetReturned.Size = new System.Drawing.Size(57, 20);
            this.btnSetReturned.TabIndex = 6;
            this.btnSetReturned.Text = "Afleveret";
            this.btnSetReturned.UseVisualStyleBackColor = true;
            this.btnSetReturned.Click += new System.EventHandler(this.Button_Click);
            this.btnSetReturned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // statusLine
            // 
            this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLineLabel});
            this.statusLine.Location = new System.Drawing.Point(0, 121);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(210, 22);
            this.statusLine.SizingGrip = false;
            this.statusLine.TabIndex = 7;
            this.statusLine.Text = "statusStrip1";
            // 
            // statusLineLabel
            // 
            this.statusLineLabel.Name = "statusLineLabel";
            this.statusLineLabel.Size = new System.Drawing.Size(88, 17);
            this.statusLineLabel.Text = "statusLineLabel";
            // 
            // txtOutlookName
            // 
            this.txtOutlookName.Location = new System.Drawing.Point(15, 38);
            this.txtOutlookName.Name = "txtOutlookName";
            this.txtOutlookName.ReadOnly = true;
            this.txtOutlookName.Size = new System.Drawing.Size(181, 20);
            this.txtOutlookName.TabIndex = 8;
            // 
            // txtDatePickedUp
            // 
            this.txtDatePickedUp.Location = new System.Drawing.Point(15, 64);
            this.txtDatePickedUp.Name = "txtDatePickedUp";
            this.txtDatePickedUp.ReadOnly = true;
            this.txtDatePickedUp.Size = new System.Drawing.Size(118, 20);
            this.txtDatePickedUp.TabIndex = 9;
            // 
            // txtDateReturned
            // 
            this.txtDateReturned.Location = new System.Drawing.Point(15, 91);
            this.txtDateReturned.Name = "txtDateReturned";
            this.txtDateReturned.ReadOnly = true;
            this.txtDateReturned.Size = new System.Drawing.Size(118, 20);
            this.txtDateReturned.TabIndex = 10;
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(158, 12);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(38, 20);
            this.btnGetOrder.TabIndex = 11;
            this.btnGetOrder.Text = "Hent";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 143);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.txtDateReturned);
            this.Controls.Add(this.txtDatePickedUp);
            this.Controls.Add(this.txtOutlookName);
            this.Controls.Add(this.statusLine);
            this.Controls.Add(this.btnSetReturned);
            this.Controls.Add(this.btnSetPickedUp);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ITMat";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            this.statusLine.ResumeLayout(false);
            this.statusLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnSetPickedUp;
        private System.Windows.Forms.Button btnSetReturned;
        private System.Windows.Forms.StatusStrip statusLine;
        private System.Windows.Forms.ToolStripStatusLabel statusLineLabel;
        private System.Windows.Forms.TextBox txtOutlookName;
        private System.Windows.Forms.TextBox txtDatePickedUp;
        private System.Windows.Forms.TextBox txtDateReturned;
        private System.Windows.Forms.Button btnGetOrder;
    }
}

