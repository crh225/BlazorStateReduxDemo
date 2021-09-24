namespace BlazorRedux.Client.Features.Todo
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class TodosState
    {
        public class AddTodoHandler : ActionHandler<TodosState.AddTodoAction>
        {
            public AddTodoHandler(IStore aStore) : base(aStore) { }

            TodosState TodoState => Store.GetState<TodosState>();

            public override Task<Unit> Handle(TodosState.AddTodoAction aIncrementCountAction, CancellationToken aCancellationToken)
            {
                //TodoState.list = TodoState.list
                return Unit.Task;
            }
        }
    }
}
