namespace Q3
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblInsertBirthday = new System.Windows.Forms.Label();
			this.txtInsertBirthday = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnResult = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblInsertBirthday
			// 
			this.lblInsertBirthday.AutoSize = true;
			this.lblInsertBirthday.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInsertBirthday.Location = new System.Drawing.Point(59, 23);
			this.lblInsertBirthday.Name = "lblInsertBirthday";
			this.lblInsertBirthday.Size = new System.Drawing.Size(247, 22);
			this.lblInsertBirthday.TabIndex = 0;
			this.lblInsertBirthday.Text = "請輸入您的生日(yyyy/MM/dd):";
			// 
			// txtInsertBirthday
			// 
			this.txtInsertBirthday.Location = new System.Drawing.Point(63, 53);
			this.txtInsertBirthday.Name = "txtInsertBirthday";
			this.txtInsertBirthday.Size = new System.Drawing.Size(243, 25);
			this.txtInsertBirthday.TabIndex = 1;
			// 
			// txtResult
			// 
			this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtResult.Location = new System.Drawing.Point(44, 97);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(446, 134);
			this.txtResult.TabIndex = 2;
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnResult.Location = new System.Drawing.Point(354, 39);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(119, 43);
			this.btnResult.TabIndex = 3;
			this.btnResult.Text = "查看結果";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 269);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtInsertBirthday);
			this.Controls.Add(this.lblInsertBirthday);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInsertBirthday;
		private System.Windows.Forms.TextBox txtInsertBirthday;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnResult;
	}
}

