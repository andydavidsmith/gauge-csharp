﻿using System;

namespace Gauge.CSharp.Lib.Attribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TagAggregationBehaviourAttribute : System.Attribute
    {
        private readonly TagAggregation _tagAggregation;

        /// <summary>
        ///     <para>Tell Gauge to look for hooks that have either all or one of the tags specified.</para>
        ///     <para>To be used when specifying multiple tags in a hook</para>
        /// </summary>
        /// <param name="tagAggregation">Tells Gauge to use all or any one of the tags.</param>
        public TagAggregationBehaviourAttribute(TagAggregation tagAggregation = TagAggregation.And)
        {
            _tagAggregation = tagAggregation;
        }

        public TagAggregation TagAggregation
        {
            get { return _tagAggregation; }
        }
    }
}
