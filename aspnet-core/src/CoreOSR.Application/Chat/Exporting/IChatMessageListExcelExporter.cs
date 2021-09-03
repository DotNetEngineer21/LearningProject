using System.Collections.Generic;
using CoreOSR.Chat.Dto;
using CoreOSR.Dto;

namespace CoreOSR.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
