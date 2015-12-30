using Disruptor_net.Metrics.Metrics;

namespace Disruptor_net.Metrics.Sinks.Serilog
{
    public class RingBufferMetricsLogItem
    {
        public string RingBufferName { get; private set; }
        public IRingbufferPerformanceMetrics Metrics { get; private set; }

        public RingBufferMetricsLogItem(string ringBufferName)
        {
            RingBufferName = ringBufferName;
        }

        public void SetMetrics(IRingbufferPerformanceMetrics metrics)
        {
            Metrics = metrics;
        }
    }
}
