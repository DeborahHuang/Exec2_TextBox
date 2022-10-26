namespace Q2
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
			this.lblInsert = new System.Windows.Forms.Label();
			this.txtInsertDateTime = new System.Windows.Forms.TextBox();
			this.btnResult = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblInsert
			// 
			this.lblInsert.AutoSize = true;
			this.lblInsert.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInsert.Location = new System.Drawing.Point(26, 32);
			this.lblInsert.Name = "lblInsert";
			this.lblInsert.Size = new System.Drawing.Size(190, 17);
			this.lblInsert.TabIndex = 0;
			this.lblInsert.Text = "請輸入一個日期(yyyy/dd/MM):";
			// 
			// txtInsertDateTime
			// 
			this.txtInsertDateTime.Location = new System.Drawing.Point(29, 62);
			this.txtInsertDateTime.Name = "txtInsertDateTime";
			this.txtInsertDateTime.Size = new System.Drawing.Size(187, 22);
			this.txtInsertDateTime.TabIndex = 1;
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnResult.Location = new System.Drawing.Point(235, 153);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(75, 23);
			this.btnResult.TabIndex = 2;
			this.btnResult.Text = "顯示結果";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(27, 110);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(46, 12);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "lblResult";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 198);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.txtInsertDateTime);
			this.Controls.Add(this.lblInsert);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Q2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInsert;
		private System.Windows.Forms.TextBox txtInsertDateTime;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.Label lblResult;
	}
}

