# AutoregressiveSignalDetection
Обнаружение гармонического сигнала методом авторегрессии.

## Постановка задачи
В данной задаче требуется оценить границы фрагмента эталонного гармонического сигнала с известной частотой, расположенного внутри массива, содержащего гармонические сигналы с другими частотами. На первом этапе реализации алгоритма обнаружения эталонного сигнала необходимо сгенерировать исследуемый сигнал. Для этого задаются частоты исходного гармонического сигнала для обнаружения и двух других синусоидальных сигналов, между которыми заключён искомый сигнал. Например, частоту искомого сигнала можно задать 𝑓0∼0.01, частоты сигналов слева и справа как 𝑓1∼0.03 и 𝑓2∼0.05. Для простоты рекомендуется использовать единичную амплитуду для всех сигналов. С учётом заданных границ (начала и конца) 𝑛1 и 𝑛2 участка эталонного сигнала исследуемый сигнал будет определяться как:
<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/formulas/formula_14.png"/></p>
Количество отсчётов может быть произвольным, рекомендуется брать 𝑁 ∼ 1000 отсчётов. Дополнительно при генерации исследуемого сигнала необходимо обеспечить непрерывность фазы (производить «сшивку» фазы на участках перехода от одного гармонического сигнала к другому), чтобы получился один плавный график трёх сигналов с разными частотами. Результат моделирования исследуемого сигнала представлен на рисунке ниже.

<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/4.png"/></p>
<p align="center">Рис. 1. Исходный синусоидальный сигнал с параметрами 𝑁 = 1024, 𝑛1 = 320, 𝑛2 = 850, 𝑓0 = 0.03, 𝑓1 = 0.06 и 𝑓2 = 0.09</p>

В данной задаче используется линейное предсказание для обнаружения сигнала заданной частоты 𝑓0. Линейное предсказание использует АР-модель.

Из теории известно, что для представления синусоидального сигнала без шума в АР-модели необходим порядок 𝑝 = 2. Это означает, что необходимо составить и аналитически решить систему нормальных уравнений Юла-Уокера для нахождения двух параметров 𝑎1 и 𝑎2 для гармонического сигнала заданной частоты 𝑓0. При этом значение 𝜌𝜔 в правой части будем полагать равным нулю.

Отсчёты исследуемого сигнала подставляются в формулу АР-модели второго порядка для линейного предсказания. Работа алгоритма предсказания начинается с третьего отсчета, поскольку предсказание зависит от двух предыдущих отсчётов. На основе полученных предсказанных отсчетов и имеющихся истинных отсчетов исследуемого сигнала вычисляется массив квадратичных ошибок предсказания, т.е. график квадратичного отклонения между предсказанием и фактическим отсчётом исходного сигнала. Можно заметить, что качественный вид графика ошибки напоминает вид синусоидального сигнала. Определить границы искомого сигнала можно пороговым методом, для чего нужно сглаживать ошибку предсказания.

В данной задаче для сглаживания данных предлагается использовать алгоритм свёрточной фильтрации во временной области. В скользящем по массиву квадратичных ошибок предсказания прямоугольном окне заданной ширины 𝐿 производится вычисление среднего значения отсчётов, которые охватывает окно. Таким образом, получается плавный график ошибки, представленный на рис. 2.

<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/5.png"/></p>
<p align="center">Рис. 2. Вид исходного и сглаженного графиков ошибки для сигнала с параметарми 𝑁 = 1024, 𝑛1 = 320 и 𝑛2 = 850</p>

Точки пересечения линии заданного порога с графиком сглаженной ошибки будем считать оценкой начала и конца искомого эталонного сигнала, соответственно.

Далее предлагается исследовать устойчивость алгоритма обнаружения границ участка гармонического сигнала с известной частотой к влиянию шума. Для этого предлагается добавить к исследуемому сигналу аддитивный белый гауссов шум, аналогично первой задаче, и выполнить алгоритм обнаружения. Уровень шума рекомендуется задавать не более 10%.

### Замечания по реализации
В данной задаче необходимо задавать через пользовательский интерфейс:
  * Частоты сигнальных составляющих;
  * Начальный и конечный индексы сигнала для обнаружения;
  * Интенсивность белого шума как дисперсию белого шума или процентную долю от полной энергии исходного сигнала;
  * Ширину окна для сглаживания ошибки;
  * Допустимый уровень ошибки (порог ошибки);
  * Уровень шума.

Требуется вывести на экран:
  * График сигнала, состоящего из трёх сигнальных составляющих;
  * График среднеквадратичного отклонения между исходным сигналом и предсказанием АР-модели, сглаженной ошибки и порога ошибки;
  * Найденные начальный и конечный индексы обнаруживаемого сигнала.
 
## Интерфейс программы
<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/1.png"/></p>
<p align="center">Рис. 3. Пользовательский интерфейс</p>

На рис. 3 приведен пользовательский интерфейс моделирующей программы. В верхнем окне программы представлен исследуемый сигнал, состоящий из трёх синусоид разной частоты, в нижнем окне представлены квадрат ошибки между исходным сигналом и результатом линейного предсказания, сглаженная ошибка и линия заданного порога. Меню слева позволяет задавать параметры генерируемого сигнала.

<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/2.png"/></p>
<p align="center">Рис. 4. Вид графиков при аддитивном белом гауссовском шуме энергией 0,10%</p>

<p align="center"><img src="https://github.com/NNGU52/AutoregressiveSignalDetection/blob/main/screenshots/3.png"/></p>
<p align="center">Рис. 5. Вид графиков при аддитивном белом гауссовском шуме энергией 1,00%</p>

По рис. 4 и 5 видно, что алгоритм перестаёт работать при наличии шума, даже если его интенсивность невелика.
