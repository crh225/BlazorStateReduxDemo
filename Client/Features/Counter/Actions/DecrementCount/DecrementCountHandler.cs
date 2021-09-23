namespace BlazorRedux.Client.Features.Counter
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class CounterState
    {
        public class DecrementCountHandler : ActionHandler<DecrementCountAction>
        {
            public DecrementCountHandler(IStore aStore) : base(aStore) { }

            CounterState CounterState => Store.GetState<CounterState>();

            public override Task<Unit> Handle(DecrementCountAction aDecrementCountAction, CancellationToken aCancellationToken)
            {
                CounterState.Count = CounterState.Count - aDecrementCountAction.Amount;
                return Unit.Task;
            }
        }
    }
}
