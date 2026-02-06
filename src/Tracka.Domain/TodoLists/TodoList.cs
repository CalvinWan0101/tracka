using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Tracka.TodoLists;
public class TodoList : FullAuditedAggregateRoot<Guid>, IMultiTenant {
    public Guid? TenantId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsHidden { get; internal set; }
    public IList<TodoTask> TodoTasks { get; internal set; } = new List<TodoTask>();
}
