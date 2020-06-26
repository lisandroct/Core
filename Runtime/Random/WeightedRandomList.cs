using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace lisandroct.Core.Random
{
    public class WeightedRandomList<T> {
        [SerializeField]
        private List<T> _elements;
        private ReadOnlyCollection<T> _elementsReadOnly;
        private ReadOnlyCollection<T> elements {
            get {
                if(_elementsReadOnly == null) {
                    _elementsReadOnly = _elements.AsReadOnly();
                }

                return _elementsReadOnly;
            }
        }

        [SerializeField]
        private List<float> _weights;
        private ReadOnlyCollection<float> _weightsReadOnly;
        private ReadOnlyCollection<float> weights {
            get {
                if(_weightsReadOnly == null) {
                    _weightsReadOnly = _weights.AsReadOnly();
                }

                return _weightsReadOnly;
            }
        }

        private int _seed;
        public int Seed {
            get => _seed;
            set {
                _seed = value;
                random = new PRNG(value);
            }
        }

        private PRNG _random;
        private PRNG random {
            get {
                if(_random == null) {
                    _random = new PRNG(Seed);
                }

                return _random;
            }
            set => _random = value;
        }

        private int? _count;
        public int Count {
            get {
                if(_count == null) {
                    _count = Mathf.Min(elements.Count, weights.Count);
                }

                return _count.Value;
            }
        }

        private float? _totalWeight;
        private float totalWeight {
            get {
                if(_totalWeight == null) {
                    float total = 0;
                    for(int i = 0, n = Count; i < n; i++) {
                        total += weights[i];
                    }

                    _totalWeight = total;
                }

                return _totalWeight.Value;
            }
        }

        public T Get() {
            if(Count < 0) {
                return default;
            } else if(Count == 1) {
                return elements[0];
            }

            float weight = random.Float(totalWeight);

            float count = 0;
            for(int i = 0, n = Count; i < n; i++) {
                count += weights[i];

                if(count >= weight) {
                    return elements[i];
                }
            }

            return default;
        }
    }
}