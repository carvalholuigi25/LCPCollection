using System.Linq.Expressions;
using System.Reflection;

namespace LCPCollection.Server.Extensions
{
    public static class MyExpressExt
    {
        /* src: https://code-maze.com/dynamic-queries-expression-trees-csharp/ */

        public static Expression<Func<TEntity, bool>> CreateEqualExpression<TEntity>(string propertyName, object value)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var member = Expression.Property(param, propertyName);
            var constant = Expression.Constant(value);
            var body = Expression.Equal(member, constant);
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        public static Expression<Func<TEntity, bool>> CreateEqualJoinExpression<TEntity>(IDictionary<string, object> filters)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            Expression? body = null;
            foreach (var pair in filters)
            {
                var member = Expression.Property(param, pair.Key);
                var constant = Expression.Constant(pair.Value);
                var expression = Expression.Equal(member, constant);
                body = body == null ? expression : Expression.AndAlso(body, expression);
            }
            return Expression.Lambda<Func<TEntity, bool>>(body!, param);
        }

        public static Expression<Func<TEntity, bool>> CreateContainsExpression<TEntity>(string propertyName, string value)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var member = Expression.Property(param, propertyName);
            var constant = Expression.Constant(value);
            var body = Expression.Call(member, "Contains", Type.EmptyTypes, constant);
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        public static Expression<Func<TEntity, bool>> CreateInExpression<TEntity>(string propertyName, object value)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var member = Expression.Property(param, propertyName);
            var propertyType = ((PropertyInfo)member.Member).PropertyType;
            var constant = Expression.Constant(value);
            var body = Expression.Call(typeof(Enumerable), "Contains", new[] { propertyType }, constant, member);
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        public static Expression<Func<TEntity, bool>> CreateNestedExpression<TEntity>(string propertyName, object value)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            Expression member = param;
            foreach (var namePart in propertyName.Split('.'))
            {
                member = Expression.Property(member, namePart);
            }
            var constant = Expression.Constant(value);
            var body = Expression.Equal(member, constant);
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        public static Expression<Func<TEntity, bool>> CreateBetweenExpression<TEntity>(string propertyName, object lowerValue, object upperValue)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var property = Expression.Property(param, propertyName);
            var body = Expression.AndAlso(
                Expression.GreaterThanOrEqual(property, Expression.Constant(lowerValue)),
                Expression.LessThanOrEqual(property, Expression.Constant(upperValue))
            );
            return Expression.Lambda<Func<TEntity, bool>>(body, param);
        }

        public static Expression<Func<TEntity, bool>> CreateTypeSafeEqualExpression<TEntity>(string propertyName, object value)
        {
            var param = Expression.Parameter(typeof(TEntity), "p");
            var member = Expression.Property(param, propertyName);
            var typeCheck = Expression.TypeEqual(Expression.Constant(value), typeof(string));
            var constant = Expression.Constant(value, typeof(object));
            var condition = Expression.Condition(
                typeCheck,
                Expression.Equal(member, constant),
                Expression.Constant(false)
            );
            return Expression.Lambda<Func<TEntity, bool>>(condition, param);
        }
    }
}
