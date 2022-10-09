using SV.Techorama.Models;

namespace SV.Techorama.Store.FindKenteken;

public record FindKentekenAction(string Kenteken);

public record KentekenFoundAction(RdwModel RdwModel);

public record FindKentekenErrorAction(string ErrorMessage);

public record ReloadKentekenInfoAction;

public record ReloadKentekenInfoSuccessAction(FindKentekenState State);