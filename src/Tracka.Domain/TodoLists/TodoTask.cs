using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Tracka.TodoLists;
public class TodoTask : FullAuditedEntity<Guid>, IMultiTenant {
    public Guid? TenantId { get; set; }
    public Guid TodoListId { get; internal set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public bool IsCompleted { get; internal set; }
}
