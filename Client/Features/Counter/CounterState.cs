using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Client.Features.Counter
{
    using BlazorState;

    public partial class CounterState : State<CounterState>
    {
        public int Count { get; private set; }
        public override void Initialize() => Count = 3;
    }
}
