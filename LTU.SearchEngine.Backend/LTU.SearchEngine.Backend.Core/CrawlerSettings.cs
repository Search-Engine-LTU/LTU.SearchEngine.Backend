using System.ComponentModel.DataAnnotations;

namespace LTU.SearchEngine.Backend.Core;

public class CrawlerSettings
{
	[Required]
	public string UserAgent { get; set; } 
	public int MaxConcurrencyPerDomain { get; set; }
	public int MinDelayMs { get; set; }


}
