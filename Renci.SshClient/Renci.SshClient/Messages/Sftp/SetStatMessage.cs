﻿
namespace Renci.SshClient.Messages.Sftp
{
    internal class SetStatMessage : SftpMessage
    {
        public override SftpMessageTypes SftpMessageType
        {
            get { return SftpMessageTypes.SetStat; }
        }

        public string Path { get; set; }

        public Attributes Attributes { get; set; }

        protected override void LoadData()
        {
            base.LoadData();
            this.Path = this.ReadString();
            this.Attributes = this.ReadAttributes();
        }

        protected override void SaveData()
        {
            base.SaveData();
            this.Write(this.Path);
            this.Write(this.Attributes);
        }
    }
}