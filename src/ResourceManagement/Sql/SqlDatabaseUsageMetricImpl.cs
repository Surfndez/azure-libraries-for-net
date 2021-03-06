// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using System;

    /// <summary>
    /// Implementation for Azure SQL Database usage.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnNxbC5pbXBsZW1lbnRhdGlvbi5TcWxEYXRhYmFzZVVzYWdlTWV0cmljSW1wbA==
    internal partial class SqlDatabaseUsageMetricImpl  :
        Wrapper<Models.DatabaseUsageInner>,
        ISqlDatabaseUsageMetric
    {
        ///GENMHASH:A0159F79F51C286DD71841E95366B32C:C0C35E00AF4E17F141675A2C05C7067B
        internal SqlDatabaseUsageMetricImpl(Models.DatabaseUsageInner innerObject)
            : base(innerObject)
        {
        }

        ///GENMHASH:98D67B93923AC46ECFE338C62748BCCB:AE6A688E48A33F4836A5CFB695421894
        public string Unit()
        {
            return this.Inner.Unit;
        }

        ///GENMHASH:19FB5490B29F08AC39628CD5F893E975:D646459DD47DA53CB973DA0F86C056D7
        public string DisplayName()
        {
            return this.Inner.DisplayName;
        }

        ///GENMHASH:3E38805ED0E7BA3CAEE31311D032A21C:61C1065B307679F3800C701AE0D87070
        public string Name()
        {
            return this.Inner.Name;
        }

        ///GENMHASH:9D196E486CC1E35756FD0BEDAB3F3BE4:1A97C3177E4C3DBBD400096F05CC2999
        public double Limit()
        {
            return this.Inner.Limit.GetValueOrDefault(0.0d);
        }

        ///GENMHASH:CFF1906C54159B35DA3E7633AE6E2E80:7850BA840C43355BE0988A1E45FB8D54
        public DateTime? NextResetTime()
        {
            return this.Inner.NextResetTime;
        }

        ///GENMHASH:59F21A39A4CDD839466D1DFD6E1A103D:192CE924095FF46A0F41D0E27BB4466A
        public string ResourceName()
        {
            return this.Inner.ResourceName;
        }

        ///GENMHASH:4CC577A7C618816C07F6CE452B96D1E6:EEAC8410C86035AD00339FF015F50F0D
        public double CurrentValue()
        {
            return this.Inner.CurrentValue.GetValueOrDefault(0.0d);
        }
    }
}