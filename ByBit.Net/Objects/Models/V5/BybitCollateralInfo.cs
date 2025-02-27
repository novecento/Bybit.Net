﻿using Newtonsoft.Json;

namespace Bybit.Net.Objects.Models.V5
{
    /// <summary>
    /// Collateral info
    /// </summary>
    public record BybitCollateralInfo
    {
        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("currency")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Hourly borrow rate
        /// </summary>
        [JsonProperty("hourlyBorrowRate")]
        public decimal HourlyBorrowRate { get; set; }
        /// <summary>
        /// Max borrow amount
        /// </summary>
        [JsonProperty("maxBorrowingAmount")]
        public decimal MaxBorrowAmount { get; set; }
        /// <summary>
        /// Free borrow amount
        /// </summary>
        [JsonProperty("freeBorrowingAmount")]
        public decimal? FreeBorrowAmount { get; set; }
        /// <summary>
        /// The maximum limit for interest-free borrowing
        /// </summary>
        [JsonProperty("freeBorrowingLimit")]
        public decimal? FreeBorrowingLimit { get; set; }
        /// <summary>
        /// Borrow amount
        /// </summary>
        [JsonProperty("borrowAmount")]
        public decimal BorrowAmount { get; set; }
        /// <summary>
        /// The sum of borrowing amount for other accounts under the same main account
        /// </summary>
        [JsonProperty("otherBorrowAmount")]
        public decimal OtherBorrowAmount { get; set; }
        /// <summary>
        /// Available to borrow
        /// </summary>
        [JsonProperty("availableToBorrow")]
        public decimal AvailableToBorrow { get; set; }
        /// <summary>
        /// Is borrowable
        /// </summary>
        [JsonProperty("borrowable")]
        public bool Borrowable { get; set; }
        /// <summary>
        /// Whether it can be used as a margin collateral currency
        /// </summary>
        [JsonProperty("marginCollateral")]
        public bool MarginCollateral { get; set; }
        /// <summary>
        /// Whether the collateral is turned on by user 
        /// </summary>
        [JsonProperty("collateralSwitch")]
        public bool CollateralSwitch { get; set; }
        /// <summary>
        /// Collateral ratio
        /// </summary>
        [JsonProperty("collateralRatio")]
        public decimal CollateralRatio { get; set; }
        /// <summary>
        /// Borrow usage rate
        /// </summary>
        [JsonProperty("borrowUsageRate")]
        public decimal? BorrowUsageRate { get; set; }
    }
}
