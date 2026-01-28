namespace LTU.SearchEngine.Backend.Core.Model;

/// <summary>
/// Represents the processing state of a crawl job within the crawl queue.
/// </summary>
/// <remarks>
/// The <see cref="CrawlJobStatus"/> enum defines the life-cycle states a crawl job
/// can transition through as it is processed by the crawler.
/// </remarks>
public enum CrawlJobStatus
{
	Pending,
	InProgress,
	Failed
}
