using System.Collections.Generic;
using CoreOSR.Auditing.Dto;
using CoreOSR.Dto;

namespace CoreOSR.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
