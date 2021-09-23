namespace BlazorRedux.Client.Features.Counter
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class CounterState
    {
        public class ResetCountHandler : ActionHandler<ResetCountAction>
        {
            public ResetCountHandler(IStore aStore) : base(aStore) { }

            CounterState CounterState => Store.GetState<CounterState>();

            public override Task<Unit> Handle(ResetCountAction aResetCountAction, CancellationToken aCancellationToken)
            {
                CounterState.Count = aResetCountAction.Amount;
                return Unit.Task;
            }
        }
    }
}
