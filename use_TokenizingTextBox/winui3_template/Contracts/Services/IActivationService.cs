namespace winui3_template.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
