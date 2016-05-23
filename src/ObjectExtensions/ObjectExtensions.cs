using System;

namespace ObjectExtensions
{
    public static class MyObjectExtensions
    {
        public static T IfNull<T>(this T self, Action<T> action)
        {
            if (self == null || self.Equals(null))
            {
                action(self);
            }
            return self;
        }

        public static T IfNotNull<T>(this T self, Action<T> action)
        {
            if (self != null && !self.Equals(null))
            {
                action(self);
            }
            return self;
        }

        public static T IfNull<T>(this T self, Action action)
        {
            if (self == null || self.Equals(null))
            {
                action();
            }
            return self;
        }

        public static T IfNotNull<T>(this T self, Action action)
        {
            if (self != null && !self.Equals(null))
            {
                action();
            }
            return self;
        }

        public static T IfNull<T>(this T self, Func<T> function)
        {
            if (self == null || self.Equals(null))
            {
                return function();
            }
            return self;
        }

        public static T IfNotNull<T>(this T self, Func<T, T> function)
        {
            if (self != null && !self.Equals(null))
            {
                return function(self);
            }
            return self;
        }

        public static TResult If<T, TResult>(this T self, Func<TResult> isNull, Func<T, TResult> isNotNull)
        {
            if (self == null && self.Equals(null))
            {
                return isNull();
            }
            else
            {
                return isNotNull(self);
            }
        }

        public static TResult If<T, TResult>(this T self, TResult isNull, Func<T, TResult> isNotNull)
        {
            if (self == null && self.Equals(null))
            {
                return isNull;
            }
            else
            {
                return isNotNull(self);
            }
        }

        public static TResult If<T, TResult>(this T self, Func<TResult> isNull, TResult isNotNull)
        {
            if (self == null && self.Equals(null))
            {
                return isNull();
            }
            else
            {
                return isNotNull;
            }
        }

        public static TResult If<T, TResult>(this T self, TResult isNull, TResult isNotNull)
        {
            if (self == null && self.Equals(null))
            {
                return isNull;
            }
            else
            {
                return isNotNull;
            }
        }
    }
}