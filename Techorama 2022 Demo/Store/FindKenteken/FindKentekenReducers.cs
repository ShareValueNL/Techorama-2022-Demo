namespace SV.Techorama.Store.FindKenteken;

public class FindKentekenReducer
{
    [ReducerMethod]
    public static FindKentekenState ReduceFindKenteken(FindKentekenState state, FindKentekenAction action)
    {
        return new FindKentekenState
        {
            Kenteken = action.Kenteken,
            Loading = true,
            RdwModel = null
        };
    }
}

public class FindKentekenErrorReducer : Reducer<FindKentekenState, FindKentekenErrorAction>
{
    public override FindKentekenState Reduce(FindKentekenState state, FindKentekenErrorAction action)
    {
        return state with
        {
            ErrorMessage = action.ErrorMessage
        };
    }
}

public class KentekenFoundReducer : Reducer<FindKentekenState, KentekenFoundAction>
{
    public override FindKentekenState Reduce(FindKentekenState state, KentekenFoundAction action)
    {
        return state with
        {
            Loading = false,
            RdwModel = action.RdwModel
        };
    }
}

public class ReloadKentekenInfoReducer : Reducer<FindKentekenState, ReloadKentekenInfoAction>
{
    public override FindKentekenState Reduce(FindKentekenState state, ReloadKentekenInfoAction action)
    {
        return state;
    }
}

public class ReloadKentekenInfoSuccessReducer : Reducer<FindKentekenState, ReloadKentekenInfoSuccessAction>
{
    public override FindKentekenState Reduce(FindKentekenState state, ReloadKentekenInfoSuccessAction action)
    {
        return action.State;
    }
}