﻿using Abp.Events.Bus;

namespace CoreOSR.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}