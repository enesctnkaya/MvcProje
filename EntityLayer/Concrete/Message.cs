﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        public bool isDraft;

        [Key]
        public int MessageID { get; set; }

        [StringLength(50)]
        public string SenderMail { get; set; } //gönderen mail

        [StringLength(50)]
        public string ReceiverMail { get; set; } //alıcı mail

        [StringLength(100)]
        public string Subject { get; set; } //konu

        public string MessageContent { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
