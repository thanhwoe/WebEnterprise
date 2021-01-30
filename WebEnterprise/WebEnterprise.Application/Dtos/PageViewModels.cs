﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Application.Dtos
{
    public class PageViewModels<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
