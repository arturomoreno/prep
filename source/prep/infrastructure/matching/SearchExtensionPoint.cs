namespace prep.infrastructure.matching
{
    public class MatchSearchExtensionPoint<ItemToMatch, PropertyType> : Where<ItemToMatch>
    {
        Accessor<ItemToMatch, PropertyType> accessor;

        public IProvideAccessToSearchingExtensions<ItemToMatch, PropertyType> not
        {
            get
            {
                return new NegatingMatchFilteringExtensionPoint<ItemToMatch, PropertyType>(this);
            }
        }

        public MatchSearchExtensionPoint(Accessor<ItemToMatch, PropertyType> accessor)
        {
            this.accessor = accessor;
        }

        public IMatchA<ItemToMatch> create_criteria_using(IMatchA<PropertyType> value_criteria)
        {
            return new PropertyMatch<ItemToMatch, PropertyType>(accessor, value_criteria);
        }
    }
}
