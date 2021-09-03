﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoreOSR.Configuration.Host.Dto
{
    public class SessionTimeOutSettingsEditDto
    {
        public bool IsEnabled { get; set; }

        [Range(10, int.MaxValue)]
        public int TimeOutSecond { get; set; }

        [Range(10, int.MaxValue)]
        public int ShowTimeOutNotificationSecond { get; set; }
    }
}
