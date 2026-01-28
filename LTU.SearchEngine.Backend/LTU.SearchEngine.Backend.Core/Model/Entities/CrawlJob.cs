namespace LTU.SearchEngine.Backend.Core.Model.Entities;

/// <summary>
/// Represents a crawl job queued for processing by the crawler.
/// </summary>
/// <remarks>
/// <para>
/// A <see cref="CrawlJob"/> models the life-cycle of a URL within the crawl queue,
/// including retry behavior and scheduling of future fetch attempts.
/// </para>
/// <para>
/// This class is a domain entity and is persisted to the crawl queue store.
/// Its state is updated as the crawler processes fetch attempts and determines
/// whether a URL should be retried, delayed, or marked as completed.
/// </para>
/// </remarks>
public class CrawlJob
{
	public int Id { get; set; }
	public string Url { get; set; } = string.Empty;
	public CrawlJobStatus Status { get; set; } 
	public int RetryCount { get; set; }
	public DateTime? LastAttempt { get; set; }
	public DateTime? NextAttempt { get; set; }
}
