using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Client.Features.Counter
{

    using BlazorState;

    public partial class CounterState
    {
        public class IncrementCountAction : IAction
        {
            public int Amount { get; set; }
        }
    }
}
