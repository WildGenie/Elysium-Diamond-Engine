﻿namespace WorldServer.BlackMarket {
    public enum CashItemPurchaseStatus : byte {
        None,
        InvalidName,
        InvalidItem,
        NotEnoughCash,
        SuccessPurchase
    }
}