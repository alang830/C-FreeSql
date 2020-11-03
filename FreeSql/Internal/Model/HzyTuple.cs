﻿﻿namespace HzySql.Models
{
    using HzySql.Interface;

    public class HzyTuple
    {
        /// <summary>
        /// 在 拉姆达表达式 where 表达式中使用 w => w.In(w.t1.Member_ID, guidsArray)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool In<T, T2>(T field, params T2[] array) => true;

        /// <summary>
        /// 子查询 只能在 Where 中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="iCurdBase"></param>
        /// <returns></returns>
        public bool In<T, T2>(T field, T2 iCurdBase) where T2 : ISqlContext => true;

        /// <summary>
        /// 在 拉姆达表达式 where 表达式中使用 w => w.NotIn(w.t1.Member_ID, guidsArray)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public bool NotIn<T, T2>(T field, params T2[] array) => true;

        /// <summary>
        /// 子查询 只能在 Where 中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="iCurdBase"></param>
        /// <returns></returns>
        public bool NotIn<T, T2>(T field, T2 iCurdBase) where T2 : ISqlContext => true;

        /// <summary>
        /// like %123% 只能在 Where 中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Like<T, T2>(T field, T2 value) => true;

        /// <summary>
        /// like 123% 只能在 Where 中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool LikeStart<T, T2>(T field, T2 value) => true;

        /// <summary>
        /// like %123 只能在 Where 中使用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool LikeEnd<T, T2>(T field, T2 value) => true;

        /// <summary>
        /// 一般在Where 条件中使用 例如 : w.HzySql("convert(varchar(50),UserName,23) > convert(varchar(50),GetDate(),23)")
        /// 一般用来支持这种语法》CONVERT(varchar(100), GETDATE(), 23)    -- 2006-05-16 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool HzySql(string value) => true;

        /// <summary>
        /// 一般在Where 条件中使用 例如 : w.HzySql<DateTime>("convert(varchar(50),UserName,23)") > DateTime.Now.ToString("yyyy-MM-dd")
        /// 一般用来支持这种语法》CONVERT(varchar(100), GETDATE(), 23)    -- 2006-05-16 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public TR HzySql<TR>(string value) => default(TR);
    }

    public class HzyTuple<T> : HzyTuple
    {
        public HzyTuple(T t)
        {
            this.t1 = t;
        }

        public T t1 { get; }
    }


    public class HzyTuple<T1, T2> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2)
        {
            this.t1 = t1; this.t2 = t2;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
    }


    public class HzyTuple<T1, T2, T3> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
        public T12 t12 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
        public T12 t12 { get; }
        public T13 t13 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
        public T12 t12 { get; }
        public T13 t13 { get; }
        public T14 t14 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
        public T12 t12 { get; }
        public T13 t13 { get; }
        public T14 t14 { get; }
        public T15 t15 { get; }
    }


    public class HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : HzyTuple
    {
        public HzyTuple(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16;
        }

        public T1 t1 { get; }
        public T2 t2 { get; }
        public T3 t3 { get; }
        public T4 t4 { get; }
        public T5 t5 { get; }
        public T6 t6 { get; }
        public T7 t7 { get; }
        public T8 t8 { get; }
        public T9 t9 { get; }
        public T10 t10 { get; }
        public T11 t11 { get; }
        public T12 t12 { get; }
        public T13 t13 { get; }
        public T14 t14 { get; }
        public T15 t15 { get; }
        public T16 t16 { get; }
    }
}
