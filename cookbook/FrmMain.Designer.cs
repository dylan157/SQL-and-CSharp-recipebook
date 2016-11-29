namespace cookbook
{
    partial class FrmMain
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
            this.cookbookDataSet = new cookbook.cookbookDataSet();
            this.lblrecipes = new System.Windows.Forms.Label();
            this.lstrecipes = new System.Windows.Forms.ListBox();
            this.lstingredients = new System.Windows.Forms.ListBox();
            this.blbingredients = new System.Windows.Forms.Label();
            this.btnaddrecipe = new System.Windows.Forms.Button();
            this.txtrecipename = new System.Windows.Forms.TextBox();
            this.btnupdaterecipename = new System.Windows.Forms.Button();
            this.lstallingredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddtorecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookbookDataSet
            // 
            this.cookbookDataSet.DataSetName = "cookbookDataSet";
            this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblrecipes
            // 
            this.lblrecipes.AutoSize = true;
            this.lblrecipes.Location = new System.Drawing.Point(86, 92);
            this.lblrecipes.Name = "lblrecipes";
            this.lblrecipes.Size = new System.Drawing.Size(63, 17);
            this.lblrecipes.TabIndex = 0;
            this.lblrecipes.Text = "Recipes:";
            // 
            // lstrecipes
            // 
            this.lstrecipes.FormattingEnabled = true;
            this.lstrecipes.ItemHeight = 16;
            this.lstrecipes.Location = new System.Drawing.Point(87, 112);
            this.lstrecipes.Name = "lstrecipes";
            this.lstrecipes.Size = new System.Drawing.Size(156, 196);
            this.lstrecipes.TabIndex = 1;
            this.lstrecipes.SelectedIndexChanged += new System.EventHandler(this.lstrecipes_SelectedIndexChanged);
            // 
            // lstingredients
            // 
            this.lstingredients.FormattingEnabled = true;
            this.lstingredients.ItemHeight = 16;
            this.lstingredients.Location = new System.Drawing.Point(89, 342);
            this.lstingredients.Name = "lstingredients";
            this.lstingredients.Size = new System.Drawing.Size(156, 196);
            this.lstingredients.TabIndex = 3;
            // 
            // blbingredients
            // 
            this.blbingredients.AutoSize = true;
            this.blbingredients.Location = new System.Drawing.Point(88, 322);
            this.blbingredients.Name = "blbingredients";
            this.blbingredients.Size = new System.Drawing.Size(130, 17);
            this.blbingredients.TabIndex = 2;
            this.blbingredients.Text = "Recipe ingredients:";
            // 
            // btnaddrecipe
            // 
            this.btnaddrecipe.Location = new System.Drawing.Point(89, 52);
            this.btnaddrecipe.Name = "btnaddrecipe";
            this.btnaddrecipe.Size = new System.Drawing.Size(112, 32);
            this.btnaddrecipe.TabIndex = 4;
            this.btnaddrecipe.Text = "Add Recipe";
            this.btnaddrecipe.UseVisualStyleBackColor = true;
            this.btnaddrecipe.Click += new System.EventHandler(this.btnaddrecipe_Click);
            // 
            // txtrecipename
            // 
            this.txtrecipename.Location = new System.Drawing.Point(89, 24);
            this.txtrecipename.Name = "txtrecipename";
            this.txtrecipename.Size = new System.Drawing.Size(232, 22);
            this.txtrecipename.TabIndex = 5;
            // 
            // btnupdaterecipename
            // 
            this.btnupdaterecipename.Location = new System.Drawing.Point(207, 52);
            this.btnupdaterecipename.Name = "btnupdaterecipename";
            this.btnupdaterecipename.Size = new System.Drawing.Size(114, 32);
            this.btnupdaterecipename.TabIndex = 6;
            this.btnupdaterecipename.Text = "update name";
            this.btnupdaterecipename.UseVisualStyleBackColor = true;
            this.btnupdaterecipename.Click += new System.EventHandler(this.btnupdaterecipename_Click);
            // 
            // lstallingredients
            // 
            this.lstallingredients.FormattingEnabled = true;
            this.lstallingredients.ItemHeight = 16;
            this.lstallingredients.Location = new System.Drawing.Point(306, 112);
            this.lstallingredients.Name = "lstallingredients";
            this.lstallingredients.Size = new System.Drawing.Size(156, 196);
            this.lstallingredients.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "all  ingredients:";
            // 
            // btnaddtorecipe
            // 
            this.btnaddtorecipe.Location = new System.Drawing.Point(468, 112);
            this.btnaddtorecipe.Name = "btnaddtorecipe";
            this.btnaddtorecipe.Size = new System.Drawing.Size(112, 32);
            this.btnaddtorecipe.TabIndex = 9;
            this.btnaddtorecipe.Text = "Add to Recipe";
            this.btnaddtorecipe.UseVisualStyleBackColor = true;
            this.btnaddtorecipe.Click += new System.EventHandler(this.btnaddtorecipe_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 593);
            this.Controls.Add(this.btnaddtorecipe);
            this.Controls.Add(this.lstallingredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdaterecipename);
            this.Controls.Add(this.txtrecipename);
            this.Controls.Add(this.btnaddrecipe);
            this.Controls.Add(this.lstingredients);
            this.Controls.Add(this.blbingredients);
            this.Controls.Add(this.lstrecipes);
            this.Controls.Add(this.lblrecipes);
            this.Name = "FrmMain";
            this.Text = "cookbook";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cookbookDataSet cookbookDataSet;
        private System.Windows.Forms.Label lblrecipes;
        private System.Windows.Forms.ListBox lstrecipes;
        private System.Windows.Forms.ListBox lstingredients;
        private System.Windows.Forms.Label blbingredients;
        private System.Windows.Forms.Button btnaddrecipe;
        private System.Windows.Forms.TextBox txtrecipename;
        private System.Windows.Forms.Button btnupdaterecipename;
        private System.Windows.Forms.ListBox lstallingredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddtorecipe;
    }
}

