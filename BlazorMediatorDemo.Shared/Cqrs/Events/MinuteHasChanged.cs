using MediatR;

namespace BlazorMediatorDemo.Shared.Cqrs.Events;

public record MinuteHasChanged() : INotification;
