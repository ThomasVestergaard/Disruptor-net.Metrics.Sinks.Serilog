using Disruptor_net.Metrics.Metrics;
using Serilog;

namespace Disruptor_net.Metrics.Sinks.Serilog
{
    public class SerilogSink : ISink
    {
        private readonly ILogger serilogLogger;
        private RingBufferMetricsLogItem logItem;

        public SerilogSink(ILogger serilogLogger, string ringBufferName)
        {
            this.serilogLogger = serilogLogger;
            logItem = new RingBufferMetricsLogItem(ringBufferName);
        }

        public void ReportMetrics(IRingbufferPerformanceMetrics metrics)
        {
            logItem.SetMetrics(metrics);
            serilogLogger.Information("{@Metrics}", logItem);
        }
    }
}
