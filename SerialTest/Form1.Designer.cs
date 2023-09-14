namespace SerialTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_Pressure = new System.Windows.Forms.Label();
            this.lbl_CorrectedDirection = new System.Windows.Forms.Label();
            this.lbl_WindSpeed = new System.Windows.Forms.Label();
            this.lbl_Dewpoint = new System.Windows.Forms.Label();
            this.lblIndoor = new System.Windows.Forms.Label();
            this.label_Pressure = new System.Windows.Forms.Label();
            this.label_CorrectedDirection = new System.Windows.Forms.Label();
            this.label_WindSpeed = new System.Windows.Forms.Label();
            this.label_WindDirection = new System.Windows.Forms.Label();
            this.cmbCOM = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label_RelativeHumidity = new System.Windows.Forms.Label();
            this.lbl_RelativeHumidity = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.lbl_Temperature = new System.Windows.Forms.Label();
            this.label_Dewpoint = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_SupplyVoltage = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_SupplyVoltage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_realtimedata = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbl_Temperature);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbl_RelativeHumidity);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_Pressure);
            this.groupBox1.Controls.Add(this.lbl_SupplyVoltage);
            this.groupBox1.Controls.Add(this.lbl_CorrectedDirection);
            this.groupBox1.Controls.Add(this.lbl_Time);
            this.groupBox1.Controls.Add(this.lbl_WindSpeed);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_Dewpoint);
            this.groupBox1.Controls.Add(this.lblIndoor);
            this.groupBox1.Controls.Add(this.label_Status);
            this.groupBox1.Controls.Add(this.label_Temperature);
            this.groupBox1.Controls.Add(this.label_SupplyVoltage);
            this.groupBox1.Controls.Add(this.label_RelativeHumidity);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_Pressure);
            this.groupBox1.Controls.Add(this.label_Date);
            this.groupBox1.Controls.Add(this.label_CorrectedDirection);
            this.groupBox1.Controls.Add(this.label_Dewpoint);
            this.groupBox1.Controls.Add(this.label_WindSpeed);
            this.groupBox1.Controls.Add(this.label_WindDirection);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 339);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recived Values";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(875, 800);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 30;
            this.label15.Text = "내부온도";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // lbl_Pressure
            // 
            this.lbl_Pressure.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pressure.Location = new System.Drawing.Point(20, 185);
            this.lbl_Pressure.Name = "lbl_Pressure";
            this.lbl_Pressure.Size = new System.Drawing.Size(236, 25);
            this.lbl_Pressure.TabIndex = 27;
            this.lbl_Pressure.Text = "Pressure";
            this.lbl_Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CorrectedDirection
            // 
            this.lbl_CorrectedDirection.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CorrectedDirection.Location = new System.Drawing.Point(20, 136);
            this.lbl_CorrectedDirection.Name = "lbl_CorrectedDirection";
            this.lbl_CorrectedDirection.Size = new System.Drawing.Size(236, 25);
            this.lbl_CorrectedDirection.TabIndex = 26;
            this.lbl_CorrectedDirection.Text = "Corrected Direction";
            this.lbl_CorrectedDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_WindSpeed
            // 
            this.lbl_WindSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WindSpeed.Location = new System.Drawing.Point(20, 87);
            this.lbl_WindSpeed.Name = "lbl_WindSpeed";
            this.lbl_WindSpeed.Size = new System.Drawing.Size(236, 25);
            this.lbl_WindSpeed.TabIndex = 25;
            this.lbl_WindSpeed.Text = "Wind Speed";
            this.lbl_WindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Dewpoint
            // 
            this.lbl_Dewpoint.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dewpoint.Location = new System.Drawing.Point(17, 40);
            this.lbl_Dewpoint.Name = "lbl_Dewpoint";
            this.lbl_Dewpoint.Size = new System.Drawing.Size(241, 23);
            this.lbl_Dewpoint.TabIndex = 24;
            this.lbl_Dewpoint.Text = "Wind Direction";
            this.lbl_Dewpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIndoor
            // 
            this.lblIndoor.BackColor = System.Drawing.Color.Green;
            this.lblIndoor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndoor.ForeColor = System.Drawing.Color.White;
            this.lblIndoor.Location = new System.Drawing.Point(875, 800);
            this.lblIndoor.Name = "lblIndoor";
            this.lblIndoor.Size = new System.Drawing.Size(103, 31);
            this.lblIndoor.TabIndex = 22;
            this.lblIndoor.Text = "0";
            this.lblIndoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIndoor.Visible = false;
            // 
            // label_Pressure
            // 
            this.label_Pressure.BackColor = System.Drawing.Color.Green;
            this.label_Pressure.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pressure.ForeColor = System.Drawing.Color.White;
            this.label_Pressure.Location = new System.Drawing.Point(262, 183);
            this.label_Pressure.Name = "label_Pressure";
            this.label_Pressure.Size = new System.Drawing.Size(255, 31);
            this.label_Pressure.TabIndex = 19;
            this.label_Pressure.Text = "0";
            this.label_Pressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CorrectedDirection
            // 
            this.label_CorrectedDirection.BackColor = System.Drawing.Color.Green;
            this.label_CorrectedDirection.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CorrectedDirection.ForeColor = System.Drawing.Color.White;
            this.label_CorrectedDirection.Location = new System.Drawing.Point(262, 134);
            this.label_CorrectedDirection.Name = "label_CorrectedDirection";
            this.label_CorrectedDirection.Size = new System.Drawing.Size(255, 31);
            this.label_CorrectedDirection.TabIndex = 18;
            this.label_CorrectedDirection.Text = "0";
            this.label_CorrectedDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WindSpeed
            // 
            this.label_WindSpeed.BackColor = System.Drawing.Color.Green;
            this.label_WindSpeed.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WindSpeed.ForeColor = System.Drawing.Color.White;
            this.label_WindSpeed.Location = new System.Drawing.Point(262, 85);
            this.label_WindSpeed.Name = "label_WindSpeed";
            this.label_WindSpeed.Size = new System.Drawing.Size(255, 31);
            this.label_WindSpeed.TabIndex = 17;
            this.label_WindSpeed.Text = "0";
            this.label_WindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WindDirection
            // 
            this.label_WindDirection.BackColor = System.Drawing.Color.Green;
            this.label_WindDirection.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WindDirection.ForeColor = System.Drawing.Color.White;
            this.label_WindDirection.Location = new System.Drawing.Point(262, 36);
            this.label_WindDirection.Name = "label_WindDirection";
            this.label_WindDirection.Size = new System.Drawing.Size(255, 31);
            this.label_WindDirection.TabIndex = 16;
            this.label_WindDirection.Text = "0";
            this.label_WindDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCOM
            // 
            this.cmbCOM.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCOM.FormattingEnabled = true;
            this.cmbCOM.Location = new System.Drawing.Point(858, 11);
            this.cmbCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCOM.Name = "cmbCOM";
            this.cmbCOM.Size = new System.Drawing.Size(106, 35);
            this.cmbCOM.TabIndex = 21;
            this.cmbCOM.SelectedIndexChanged += new System.EventHandler(this.cmbCOM_SelectedIndexChanged);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(969, 11);
            this.btnConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(130, 35);
            this.btnConn.TabIndex = 22;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(513, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(339, 30);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Please connect a COM port before executing";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_RelativeHumidity
            // 
            this.label_RelativeHumidity.BackColor = System.Drawing.Color.Green;
            this.label_RelativeHumidity.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RelativeHumidity.ForeColor = System.Drawing.Color.White;
            this.label_RelativeHumidity.Location = new System.Drawing.Point(262, 232);
            this.label_RelativeHumidity.Name = "label_RelativeHumidity";
            this.label_RelativeHumidity.Size = new System.Drawing.Size(255, 31);
            this.label_RelativeHumidity.TabIndex = 19;
            this.label_RelativeHumidity.Text = "0";
            this.label_RelativeHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RelativeHumidity
            // 
            this.lbl_RelativeHumidity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RelativeHumidity.Location = new System.Drawing.Point(20, 234);
            this.lbl_RelativeHumidity.Name = "lbl_RelativeHumidity";
            this.lbl_RelativeHumidity.Size = new System.Drawing.Size(236, 25);
            this.lbl_RelativeHumidity.TabIndex = 27;
            this.lbl_RelativeHumidity.Text = "Relative Humidity";
            this.lbl_RelativeHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Temperature
            // 
            this.label_Temperature.BackColor = System.Drawing.Color.Green;
            this.label_Temperature.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Temperature.ForeColor = System.Drawing.Color.White;
            this.label_Temperature.Location = new System.Drawing.Point(262, 281);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(255, 31);
            this.label_Temperature.TabIndex = 19;
            this.label_Temperature.Text = "0";
            this.label_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Temperature
            // 
            this.lbl_Temperature.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temperature.Location = new System.Drawing.Point(20, 283);
            this.lbl_Temperature.Name = "lbl_Temperature";
            this.lbl_Temperature.Size = new System.Drawing.Size(236, 25);
            this.lbl_Temperature.TabIndex = 27;
            this.lbl_Temperature.Text = "Temperature";
            this.lbl_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Dewpoint
            // 
            this.label_Dewpoint.BackColor = System.Drawing.Color.Green;
            this.label_Dewpoint.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dewpoint.ForeColor = System.Drawing.Color.White;
            this.label_Dewpoint.Location = new System.Drawing.Point(796, 36);
            this.label_Dewpoint.Name = "label_Dewpoint";
            this.label_Dewpoint.Size = new System.Drawing.Size(255, 31);
            this.label_Dewpoint.TabIndex = 16;
            this.label_Dewpoint.Text = "0";
            this.label_Dewpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Date
            // 
            this.label_Date.BackColor = System.Drawing.Color.Green;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(796, 85);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(255, 31);
            this.label_Date.TabIndex = 17;
            this.label_Date.Text = "0";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Time
            // 
            this.label_Time.BackColor = System.Drawing.Color.Green;
            this.label_Time.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(796, 134);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(255, 31);
            this.label_Time.TabIndex = 18;
            this.label_Time.Text = "0";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SupplyVoltage
            // 
            this.label_SupplyVoltage.BackColor = System.Drawing.Color.Green;
            this.label_SupplyVoltage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplyVoltage.ForeColor = System.Drawing.Color.White;
            this.label_SupplyVoltage.Location = new System.Drawing.Point(796, 183);
            this.label_SupplyVoltage.Name = "label_SupplyVoltage";
            this.label_SupplyVoltage.Size = new System.Drawing.Size(255, 31);
            this.label_SupplyVoltage.TabIndex = 19;
            this.label_SupplyVoltage.Text = "0";
            this.label_SupplyVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Status
            // 
            this.label_Status.BackColor = System.Drawing.Color.Green;
            this.label_Status.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.Color.White;
            this.label_Status.Location = new System.Drawing.Point(796, 232);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(255, 31);
            this.label_Status.TabIndex = 19;
            this.label_Status.Text = "0";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(551, 40);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(241, 23);
            this.lbl_Date.TabIndex = 24;
            this.lbl_Date.Text = "Dewpoint";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(554, 87);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(236, 25);
            this.lbl_Time.TabIndex = 25;
            this.lbl_Time.Text = "Date";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SupplyVoltage
            // 
            this.lbl_SupplyVoltage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyVoltage.Location = new System.Drawing.Point(554, 136);
            this.lbl_SupplyVoltage.Name = "lbl_SupplyVoltage";
            this.lbl_SupplyVoltage.Size = new System.Drawing.Size(236, 25);
            this.lbl_SupplyVoltage.TabIndex = 26;
            this.lbl_SupplyVoltage.Text = "Time";
            this.lbl_SupplyVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(554, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Supply Voltage";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(554, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(236, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Status";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_realtimedata
            // 
            this.tbx_realtimedata.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbx_realtimedata.Location = new System.Drawing.Point(12, 34);
            this.tbx_realtimedata.Name = "tbx_realtimedata";
            this.tbx_realtimedata.Size = new System.Drawing.Size(1063, 35);
            this.tbx_realtimedata.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_realtimedata);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realtime Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.cmbCOM);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GMX500 Serial Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_Pressure;
        private System.Windows.Forms.Label lbl_CorrectedDirection;
        private System.Windows.Forms.Label lbl_WindSpeed;
        private System.Windows.Forms.Label lbl_Dewpoint;
        private System.Windows.Forms.Label lblIndoor;
        private System.Windows.Forms.Label label_Pressure;
        private System.Windows.Forms.Label label_CorrectedDirection;
        private System.Windows.Forms.Label label_WindSpeed;
        private System.Windows.Forms.Label label_WindDirection;
        private System.Windows.Forms.ComboBox cmbCOM;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_Temperature;
        private System.Windows.Forms.Label lbl_RelativeHumidity;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.Label label_RelativeHumidity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_SupplyVoltage;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_SupplyVoltage;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Dewpoint;
        private System.Windows.Forms.MaskedTextBox tbx_realtimedata;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

