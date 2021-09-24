namespace BlazorRedux.Client.Features.Todo
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class TodoState
    {
        public class DeleteTodoHandler : ActionHandler<TodosState.DeleteTodoAction>
        {
            public DeleteTodoHandler(IStore aStore) : base(aStore) { }

            TodoState State => Store.GetState<TodoState>();

            public override Task<Unit> Handle(TodosState.DeleteTodoAction aTodoAction, CancellationToken aCancellationToken)
            {
                State.TheList.Remove(aTodoAction.payload);
                State.TheList.TrimExcess();
                return Unit.Task;
            }
        }
    }
}
