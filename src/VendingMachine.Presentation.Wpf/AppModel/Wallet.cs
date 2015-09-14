﻿using System.Collections.ObjectModel;

namespace VendingMachine.Presentation.Wpf.AppModel
{
    public sealed class Wallet : AppModelBase
    {
        public ObservableCollection<CoinSet> Coins { get; } = new ObservableCollection<CoinSet>();
    }
}