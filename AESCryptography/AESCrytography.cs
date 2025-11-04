using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESCryptography
{
    internal class AESCrytography
    {
        const int BLOCK_SIZE = 16; // 128 bits

        #region Encrypt
        public byte[] Encrypt(byte[] simpleText, byte[] key)
        {
            ExpandKey(key);
            List<byte[]> blocos = DivideInBlocks(simpleText, true);

            foreach (byte[] bloco in blocos)
            {
                byte[] blocoCifrado = CypherBlock(bloco);
                Persistir(blocoCifrado);
            }
            return [];
        }

        private byte[] CypherBlock(byte[] bloco)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Decrypt
        public byte[] Decrypt(byte[] encryptedText, byte[] key)
        {
            ExpandKey(key);
            List<byte[]> blocos = DivideInBlocks(encryptedText, false);

            foreach (byte[] bloco in blocos)
            {
                byte[] blocoDecifrado = DecypherBlock(bloco);
                Persistir(blocoDecifrado);
            }
            RemoveFilling();

            return [];
        }

        private byte[] DecypherBlock(byte[] bloco)
        {
            throw new NotImplementedException();
        }

        private void RemoveFilling()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Util
        private List<byte[]> DivideInBlocks(byte[] text, bool needsPadding)
        {
            List<byte[]> blocks = new List<byte[]>();

            for (int i = 0; i < text.Length; i += BLOCK_SIZE)
            {
                blocks.Add(text.Skip(i).Take(BLOCK_SIZE).ToArray());
            }

            if (needsPadding)
            {
                int rest = text.Length % BLOCK_SIZE;
                byte[] lastBlock = new byte[BLOCK_SIZE];

                if (rest != 0)
                {
                    Array.Copy(text, text.Length - rest, lastBlock, 0, rest);
                    byte paddingValue = (byte)(BLOCK_SIZE - rest);
                    for (int i = rest; i < BLOCK_SIZE; i++)
                    {
                        lastBlock[i] = (paddingValue);
                    }
                    blocks.Add(lastBlock);
                }
                else
                {
                    byte paddingValue = (byte)BLOCK_SIZE;
                    for (int i = 0; i < BLOCK_SIZE; i++)
                    {
                        lastBlock[i] = paddingValue;
                    }
                    blocks.Add(lastBlock);
                }
            }

            return blocks;
        }

        #region ExpandKey
        private void ExpandKey(byte[] key)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void Persistir(byte[] blocoCifrado)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
