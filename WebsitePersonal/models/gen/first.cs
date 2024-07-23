namespace BlazorApp1.models.gen;

public class first
{
    
}


public class Items9
{
    public string $ref { get; set; }
}

public class VendorComments
{
    public string type { get; set; }
    public Items10 items { get; set; }
}

public class Items10
{
    public string $ref { get; set; }
}

public class Cvss_v2
{
    public Properties5 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties5
{
    public Source source { get; set; }
    public Type type { get; set; }
    public CvssData cvssData { get; set; }
    public BaseSeverity baseSeverity { get; set; }
    public ExploitabilityScore exploitabilityScore { get; set; }
    public ImpactScore impactScore { get; set; }
    public AcInsufInfo acInsufInfo { get; set; }
    public ObtainAllPrivilege obtainAllPrivilege { get; set; }
    public ObtainUserPrivilege obtainUserPrivilege { get; set; }
    public ObtainOtherPrivilege obtainOtherPrivilege { get; set; }
    public UserInteractionRequired userInteractionRequired { get; set; }
}

public class Source
{
    public string type { get; set; }
}

public class Type
{
    public string[] enum { get; set; }
}

public class CvssData
{
    public string $ref { get; set; }
}

public class BaseSeverity
{
    public string type { get; set; }
}

public class ExploitabilityScore
{
    public string $ref { get; set; }
}

public class ImpactScore
{
    public string $ref { get; set; }
}

public class AcInsufInfo
{
    public string type { get; set; }
}

public class ObtainAllPrivilege
{
    public string type { get; set; }
}

public class ObtainUserPrivilege
{
    public string type { get; set; }
}

public class ObtainOtherPrivilege
{
    public string type { get; set; }
}

public class UserInteractionRequired
{
    public string type { get; set; }
}

public class Cvss_v30
{
    public Properties6 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties6
{
    public Source1 source { get; set; }
    public Type1 type { get; set; }
    public CvssData1 cvssData { get; set; }
    public ExploitabilityScore1 exploitabilityScore { get; set; }
    public ImpactScore1 impactScore { get; set; }
}

public class Source1
{
    public string type { get; set; }
}

public class Type1
{
    public string[] enum { get; set; }
}

public class CvssData1
{
    public string $ref { get; set; }
}

public class ExploitabilityScore1
{
    public string $ref { get; set; }
}

public class ImpactScore1
{
    public string $ref { get; set; }
}

public class Cvss_v31
{
    public Properties7 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties7
{
    public Source2 source { get; set; }
    public Type2 type { get; set; }
    public CvssData2 cvssData { get; set; }
    public ExploitabilityScore2 exploitabilityScore { get; set; }
    public ImpactScore2 impactScore { get; set; }
}

public class Source2
{
    public string type { get; set; }
}

public class Type2
{
    public string[] enum { get; set; }
}

public class CvssData2
{
    public string $ref { get; set; }
}

public class ExploitabilityScore2
{
    public string $ref { get; set; }
}

public class ImpactScore2
{
    public string $ref { get; set; }
}

public class Cvss_v40
{
    public Properties8 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties8
{
    public Source3 source { get; set; }
    public Type3 type { get; set; }
    public CvssData3 cvssData { get; set; }
}

public class Source3
{
    public string type { get; set; }
}

public class Type3
{
    public string[] enum { get; set; }
}

public class CvssData3
{
    public string $ref { get; set; }
}

public class Cve_id
{
    public string type { get; set; }
    public string pattern { get; set; }
}

public class Lang_string
{
    public string type { get; set; }
    public Properties9 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties9
{
    public Lang lang { get; set; }
    public Value value { get; set; }
}

public class Lang
{
    public string type { get; set; }
}

public class Value
{
    public string type { get; set; }
    public int maxLength { get; set; }
}

public class Reference
{
    public string type { get; set; }
    public Properties10 properties { get; set; }
    public string[] required { get; set; }
}

public class Properties10
{
    public Url url { get; set; }
    public Source4 source { get; set; }
    public Tags1 tags { get; set; }
}

public class Url
{
    public int maxLength { get; set; }
    public string type { get; set; }
    public string pattern { get; set; }
}

public class Source4
{
    public string type { get; set; }
}

public class Tags1
{
    public string type { get; set; }
    public Items11 items { get; set; }
}

public class Items11
{
    public string type { get; set; }
}

public class VendorComment
{
    public string type { get; set; }
    public Properties11 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties11
{
    public Organization organization { get; set; }
    public Comment comment { get; set; }
    public LastModified1 lastModified { get; set; }
}

public class Organization
{
    public string type { get; set; }
}

public class Comment
{
    public string type { get; set; }
}

public class LastModified1
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Weakness
{
    public Properties12 properties { get; set; }
    public string[] required { get; set; }
    public bool additionalProperties { get; set; }
}

public class Properties12
{
    public Source5 source { get; set; }
    public Type4 type { get; set; }
    public Description description { get; set; }
}

public class Source5
{
    public string type { get; set; }
}

public class Type4
{
    public string type { get; set; }
}

public class Description
{
    public string type { get; set; }
    public int minItems { get; set; }
    public Items12 items { get; set; }
}

public class Items12
{
    public string $ref { get; set; }
}

public class Config
{
    public Properties13 properties { get; set; }
    public string[] required { get; set; }
}

public class Properties13
{
    public Operator operator { get; set; }
    public Negate negate { get; set; }
    public Nodes nodes { get; set; }
}

public class Operator
{
    public string type { get; set; }
    public string[] enum { get; set; }
}

public class Negate
{
    public string type { get; set; }
}

public class Nodes
{
    public string type { get; set; }
    public Items13 items { get; set; }
}

public class Items13
{
    public string $ref { get; set; }
}

public class Node
{
    public string description { get; set; }
    public Properties14 properties { get; set; }
    public string[] required { get; set; }
}

public class Properties14
{
    public Operator1 operator { get; set; }
    public Negate1 negate { get; set; }
    public CpeMatch cpeMatch { get; set; }
}

public class Operator1
{
    public string type { get; set; }
    public string[] enum { get; set; }
}

public class Negate1
{
    public string type { get; set; }
}

public class CpeMatch
{
    public string type { get; set; }
    public Items14 items { get; set; }
}

public class Items14
{
    public string $ref { get; set; }
}

public class Cpe_match
{
    public string description { get; set; }
    public string type { get; set; }
    public Properties15 properties { get; set; }
    public string[] required { get; set; }
}

public class Properties15
{
    public Vulnerable vulnerable { get; set; }
    public Criteria criteria { get; set; }
    public MatchCriteriaId matchCriteriaId { get; set; }
    public VersionStartExcluding versionStartExcluding { get; set; }
    public VersionStartIncluding versionStartIncluding { get; set; }
    public VersionEndExcluding versionEndExcluding { get; set; }
    public VersionEndIncluding versionEndIncluding { get; set; }
}

public class Vulnerable
{
    public string type { get; set; }
}

public class Criteria
{
    public string type { get; set; }
}

public class MatchCriteriaId
{
    public string type { get; set; }
    public string format { get; set; }
}

public class VersionStartExcluding
{
    public string type { get; set; }
}

public class VersionStartIncluding
{
    public string type { get; set; }
}

public class VersionEndExcluding
{
    public string type { get; set; }
}

public class VersionEndIncluding
{
    public string type { get; set; }
}

public class Def_subscore
{
    public string description { get; set; }
    public string type { get; set; }
    public int minimum { get; set; }
    public int maximum { get; set; }
}

public class Properties
{
    public ResultsPerPage resultsPerPage { get; set; }
    public StartIndex startIndex { get; set; }
    public TotalResults totalResults { get; set; }
    public Format format { get; set; }
    public Version version { get; set; }
    public Timestamp timestamp { get; set; }
    public Vulnerabilities vulnerabilities { get; set; }
}

public class ResultsPerPage
{
    public string type { get; set; }
}

public class StartIndex
{
    public string type { get; set; }
}

public class TotalResults
{
    public string type { get; set; }
}

public class Format
{
    public string type { get; set; }
}

public class Version
{
    public string type { get; set; }
}

public class Timestamp
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Vulnerabilities
{
    public string description { get; set; }
    public string type { get; set; }
    public Items15 items { get; set; }
}

public class Items15
{
    public string $ref { get; set; }
}