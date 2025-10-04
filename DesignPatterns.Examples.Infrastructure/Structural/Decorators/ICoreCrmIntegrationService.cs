using DesignPatterns.Examples.Application.Models;

namespace DesignPatterns.Examples.Infrastructure.Structural.Decorators;

public interface ICoreCrmIntegrationService
{
    void Sync(OrderInputModel model);
}