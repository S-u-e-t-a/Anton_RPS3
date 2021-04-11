namespace Lab3
{
    partial class Table
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
            this.TableFunc = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // TableFunc
            // 
            this.TableFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.y2});
            this.TableFunc.Location = new System.Drawing.Point(12, 12);
            this.TableFunc.Name = "TableFunc";
            this.TableFunc.Size = new System.Drawing.Size(351, 424);
            this.TableFunc.TabIndex = 0;
            // 
            // x
            // 
            this.x.HeaderText = "Координата Х";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.HeaderText = "Координата Y";
            this.y.Name = "y";
            // 
            // y2
            // 
            this.y2.HeaderText = "Координата -Y";
            this.y2.Name = "y2";
            // 
            // ExcelButton
            // 
            this.ExcelButton.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.ExcelButton.Location = new System.Drawing.Point(13, 443);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(350, 35);
            this.ExcelButton.TabIndex = 1;
            this.ExcelButton.Text = "Экспорт в Excel";
            this.ExcelButton.UseVisualStyleBackColor = true;
            this.ExcelButton.Click += new System.EventHandler(this.ExcelButton_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 490);
            this.Controls.Add(this.ExcelButton);
            this.Controls.Add(this.TableFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Table";
            this.Text = "Таблица значений";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2;
        private System.Windows.Forms.Button ExcelButton;
        public System.Windows.Forms.DataGridView TableFunc;
    }
}