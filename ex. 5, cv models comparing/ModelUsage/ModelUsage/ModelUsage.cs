using System;
using Tensorflow;

namespace ModelUsage
{
    class ModelUsage
    {
        static void Main(string[] args)
        {
            

            using (var sess = tf.Session())
            {
                var saver = tf.train.Saver();
                saver.save(sess, "ensorflowModel.ckpt");
            }
        }
    }
}
