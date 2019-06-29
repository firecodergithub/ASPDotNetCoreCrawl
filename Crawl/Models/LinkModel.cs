﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCrawler.Models
{
    public class LinkModel
    {
        public string Address { get; private set; }
        public bool CheckingFinished { get; private set; }
        private int _StatusCode;

        public string Referrer { get; private set; }

        public int StatusCode
        {
            get
            {
                return _StatusCode;
            }
            set
            {
                _StatusCode = value;
                this.CheckingFinished = true;
            }
        }

        public LinkModel (string Address,string Referrer)
        {
            this.Address = Address;
            this.CheckingFinished = false;
            this.Referrer=Referrer;
        }

    }
}
