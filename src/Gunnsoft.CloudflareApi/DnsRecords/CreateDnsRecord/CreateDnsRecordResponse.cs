﻿namespace Gunnsoft.CloudflareApi.DnsRecords.CreateDnsRecord
{
    public class CreateDnsRecordResponse
    {
        public CreateDnsRecordResponse(DnsRecord result)
        {
            DnsRecord = result;
        }

        public DnsRecord DnsRecord { get; }
    }
}