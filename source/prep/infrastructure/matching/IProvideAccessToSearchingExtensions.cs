namespace prep.infrastructure.matching
{
  public interface IProvideAccessToSearchingExtensions<ItemToMatch, PropertyType>
  {
    IMatchA<ItemToMatch> create_criteria_using(IMatchA<PropertyType> value_criteria);
  }
}