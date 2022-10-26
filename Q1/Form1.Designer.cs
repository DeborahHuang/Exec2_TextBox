namespace Q1
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
			this.txtInsertNumber = new System.Windows.Forms.TextBox();
			this.btnResult = new System.Windows.Forms.Button();
			this.lblInsertNumber = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInsertNumber
			// 
			this.txtInsertNumber.Location = new System.Drawing.Point(183, 42);
			this.txtInsertNumber.MaxLength = 3;
			this.txtInsertNumber.Name = "txtInsertNumber";
			this.txtInsertNumber.Size = new System.Drawing.Size(53, 22);
			this.txtInsertNumber.TabIndex = 0;
			// 
			// btnResult
			// 
			this.btnResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnResult.Location = new System.Drawing.Point(224, 182);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(75, 23);
			this.btnResult.TabIndex = 1;
			this.btnResult.Text = "顯示結果";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// lblInsertNumber
			// 
			this.lblInsertNumber.AutoSize = true;
			this.lblInsertNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInsertNumber.Location = new System.Drawing.Point(52, 42);
			this.lblInsertNumber.Name = "lblInsertNumber";
			this.lblInsertNumber.Size = new System.Drawing.Size(109, 20);
			this.lblInsertNumber.TabIndex = 2;
			this.lblInsertNumber.Text = "請輸入一個數:";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(53, 103);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(44, 17);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 217);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblInsertNumber);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.txtInsertNumber);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "輸入1~99之間的數";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInsertNumber;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.Label lblInsertNumber;
		private System.Windows.Forms.Label lblResult;
	}
}

