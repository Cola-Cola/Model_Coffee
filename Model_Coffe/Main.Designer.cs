namespace Model_Coffe
{
    partial class Main
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
            this.WaterTemp_txtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AirTeamp_txtBx = new System.Windows.Forms.TextBox();
            this.k_txtBx = new System.Windows.Forms.TextBox();
            this.MakeModel_btn = new System.Windows.Forms.Button();
            this.formsPlot2 = new ScottPlot.FormsPlot();
            this.Add_model = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.formsPlot3 = new ScottPlot.FormsPlot();
            this.formsPlot4 = new ScottPlot.FormsPlot();
            this.SuspendLayout();
            // 
            // WaterTemp_txtBx
            // 
            this.WaterTemp_txtBx.Location = new System.Drawing.Point(201, 13);
            this.WaterTemp_txtBx.Name = "WaterTemp_txtBx";
            this.WaterTemp_txtBx.Size = new System.Drawing.Size(100, 20);
            this.WaterTemp_txtBx.TabIndex = 0;
            this.WaterTemp_txtBx.Text = "88";
            this.WaterTemp_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WaterTemp_txtBx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура жидкости";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Температура среды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "k";
            // 
            // AirTeamp_txtBx
            // 
            this.AirTeamp_txtBx.Location = new System.Drawing.Point(201, 39);
            this.AirTeamp_txtBx.Name = "AirTeamp_txtBx";
            this.AirTeamp_txtBx.Size = new System.Drawing.Size(100, 20);
            this.AirTeamp_txtBx.TabIndex = 5;
            this.AirTeamp_txtBx.Text = "22";
            this.AirTeamp_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AirTeamp_txtBx_KeyPress);
            // 
            // k_txtBx
            // 
            this.k_txtBx.Location = new System.Drawing.Point(201, 65);
            this.k_txtBx.Name = "k_txtBx";
            this.k_txtBx.Size = new System.Drawing.Size(100, 20);
            this.k_txtBx.TabIndex = 7;
            this.k_txtBx.Text = "0,1";
            this.k_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.k_txtBx_KeyPress);
            // 
            // MakeModel_btn
            // 
            this.MakeModel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeModel_btn.Location = new System.Drawing.Point(16, 98);
            this.MakeModel_btn.Name = "MakeModel_btn";
            this.MakeModel_btn.Size = new System.Drawing.Size(142, 23);
            this.MakeModel_btn.TabIndex = 9;
            this.MakeModel_btn.Text = "Смоделировать";
            this.MakeModel_btn.UseVisualStyleBackColor = true;
            this.MakeModel_btn.Click += new System.EventHandler(this.MakeModel_btn_Click);
            // 
            // formsPlot2
            // 
            this.formsPlot2.Location = new System.Drawing.Point(965, 12);
            this.formsPlot2.Name = "formsPlot2";
            this.formsPlot2.Size = new System.Drawing.Size(640, 318);
            this.formsPlot2.TabIndex = 10;
            // 
            // Add_model
            // 
            this.Add_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_model.Location = new System.Drawing.Point(16, 127);
            this.Add_model.Name = "Add_model";
            this.Add_model.Size = new System.Drawing.Size(142, 43);
            this.Add_model.TabIndex = 11;
            this.Add_model.Text = "Смоделировать дополнительно";
            this.Add_model.UseVisualStyleBackColor = true;
            this.Add_model.Click += new System.EventHandler(this.Add_model_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(307, 12);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(640, 319);
            this.formsPlot1.TabIndex = 12;
            // 
            // formsPlot3
            // 
            this.formsPlot3.Location = new System.Drawing.Point(307, 359);
            this.formsPlot3.Name = "formsPlot3";
            this.formsPlot3.Size = new System.Drawing.Size(640, 318);
            this.formsPlot3.TabIndex = 13;
            // 
            // formsPlot4
            // 
            this.formsPlot4.Location = new System.Drawing.Point(965, 359);
            this.formsPlot4.Name = "formsPlot4";
            this.formsPlot4.Size = new System.Drawing.Size(640, 318);
            this.formsPlot4.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 689);
            this.Controls.Add(this.formsPlot4);
            this.Controls.Add(this.formsPlot3);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.Add_model);
            this.Controls.Add(this.formsPlot2);
            this.Controls.Add(this.MakeModel_btn);
            this.Controls.Add(this.k_txtBx);
            this.Controls.Add(this.AirTeamp_txtBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterTemp_txtBx);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WaterTemp_txtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AirTeamp_txtBx;
        private System.Windows.Forms.TextBox k_txtBx;
        private System.Windows.Forms.Button MakeModel_btn;
        private ScottPlot.FormsPlot formsPlot2;
        private System.Windows.Forms.Button Add_model;
        private ScottPlot.FormsPlot formsPlot1;
        private ScottPlot.FormsPlot formsPlot3;
        private ScottPlot.FormsPlot formsPlot4;
    }
}

