
namespace Jewelry
{
    partial class EstimationScreen
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
            this.lbl_GoldPrice = new System.Windows.Forms.Label();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.txt_GoldPrice = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_PrintToScreen = new System.Windows.Forms.Button();
            this.btn_PrintToFile = new System.Windows.Forms.Button();
            this.btn_PrintToPaper = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_GoldPrice
            // 
            this.lbl_GoldPrice.AutoSize = true;
            this.lbl_GoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GoldPrice.Location = new System.Drawing.Point(141, 80);
            this.lbl_GoldPrice.Name = "lbl_GoldPrice";
            this.lbl_GoldPrice.Size = new System.Drawing.Size(127, 13);
            this.lbl_GoldPrice.TabIndex = 0;
            this.lbl_GoldPrice.Text = "Gold Price (per gram)";
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(145, 118);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(92, 13);
            this.lbl_Weight.TabIndex = 1;
            this.lbl_Weight.Text = "Weight (grams)";
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(145, 210);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(69, 13);
            this.lbl_TotalPrice.TabIndex = 2;
            this.lbl_TotalPrice.Text = "Total Price";
            // 
            // txt_GoldPrice
            // 
            this.txt_GoldPrice.Location = new System.Drawing.Point(272, 77);
            this.txt_GoldPrice.Name = "txt_GoldPrice";
            this.txt_GoldPrice.Size = new System.Drawing.Size(255, 20);
            this.txt_GoldPrice.TabIndex = 3;
            this.txt_GoldPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GoldPrice_KeyPress);
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(272, 118);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(255, 20);
            this.txt_Weight.TabIndex = 4;
            this.txt_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Weight_KeyPress);
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Enabled = false;
            this.txt_TotalPrice.Location = new System.Drawing.Point(272, 203);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.Size = new System.Drawing.Size(116, 20);
            this.txt_TotalPrice.TabIndex = 5;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(268, 249);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(70, 13);
            this.lbl_Discount.TabIndex = 6;
            this.lbl_Discount.Text = "Discount %";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Enabled = false;
            this.txt_Discount.Location = new System.Drawing.Point(344, 242);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(44, 20);
            this.txt_Discount.TabIndex = 7;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Calculate.Location = new System.Drawing.Point(76, 319);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(87, 41);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_PrintToScreen
            // 
            this.btn_PrintToScreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PrintToScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintToScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PrintToScreen.Location = new System.Drawing.Point(195, 319);
            this.btn_PrintToScreen.Name = "btn_PrintToScreen";
            this.btn_PrintToScreen.Size = new System.Drawing.Size(87, 41);
            this.btn_PrintToScreen.TabIndex = 9;
            this.btn_PrintToScreen.Text = "Print to Screen";
            this.btn_PrintToScreen.UseVisualStyleBackColor = false;
            this.btn_PrintToScreen.Click += new System.EventHandler(this.btn_PrintToScreen_Click);
            // 
            // btn_PrintToFile
            // 
            this.btn_PrintToFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PrintToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintToFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PrintToFile.Location = new System.Drawing.Point(315, 319);
            this.btn_PrintToFile.Name = "btn_PrintToFile";
            this.btn_PrintToFile.Size = new System.Drawing.Size(87, 41);
            this.btn_PrintToFile.TabIndex = 10;
            this.btn_PrintToFile.Text = "Print to File";
            this.btn_PrintToFile.UseVisualStyleBackColor = false;
            this.btn_PrintToFile.Click += new System.EventHandler(this.btn_PrintToFile_Click);
            // 
            // btn_PrintToPaper
            // 
            this.btn_PrintToPaper.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PrintToPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintToPaper.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PrintToPaper.Location = new System.Drawing.Point(443, 319);
            this.btn_PrintToPaper.Name = "btn_PrintToPaper";
            this.btn_PrintToPaper.Size = new System.Drawing.Size(87, 41);
            this.btn_PrintToPaper.TabIndex = 11;
            this.btn_PrintToPaper.Text = "Print to Paper";
            this.btn_PrintToPaper.UseVisualStyleBackColor = false;
            this.btn_PrintToPaper.Click += new System.EventHandler(this.btn_PrintToPaper_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.Location = new System.Drawing.Point(443, 367);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(87, 37);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(412, 23);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(63, 13);
            this.lbl_Welcome.TabIndex = 13;
            this.lbl_Welcome.Text = "Welcome:";
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Location = new System.Drawing.Point(490, 23);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(0, 13);
            this.lbl_UserType.TabIndex = 14;
            // 
            // EstimationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(619, 416);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_PrintToPaper);
            this.Controls.Add(this.btn_PrintToFile);
            this.Controls.Add(this.btn_PrintToScreen);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.txt_TotalPrice);
            this.Controls.Add(this.txt_Weight);
            this.Controls.Add(this.txt_GoldPrice);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.lbl_Weight);
            this.Controls.Add(this.lbl_GoldPrice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EstimationScreen";
            this.Text = "EstimationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GoldPrice;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.TextBox txt_GoldPrice;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_PrintToScreen;
        private System.Windows.Forms.Button btn_PrintToFile;
        private System.Windows.Forms.Button btn_PrintToPaper;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_UserType;
    }
}