﻿using BaseLibS.Param;
using PerseusApi.Generic;
using PerseusApi.Matrix;

namespace PerseusApi.Image{
	/// <summary>
	/// Merge a network and a matrix
	/// </summary>
	public interface IImageMergeWithMatrix : IImageActivity, IMergeWithMatrix{
		/// <summary>
		/// Merge the input network with the provided matrix.
		/// </summary>
		/// <param name="data"></param>
		/// <param name="inMatrix"></param>
		/// <param name="param"></param>
		/// <param name="supplData"></param>
		/// <param name="processInfo"></param>
		/// <returns></returns>
		IImageData ProcessData(IImageData data, IMatrixData inMatrix, Parameters param, ref IData[] supplData,
			ProcessInfo processInfo);

		/// <summary>
		/// Define here the parameters that determine the specifics of the processing.
		/// </summary>
		/// <param name="data">The parameters might depend on the data.</param>
		/// <param name="inMatrix">and on the matrix as well.</param>
		/// <param name="errString">Set this to a value != null if an error occured. The error string will be displayed to the user.</param>
		/// <returns>The set of parameters.</returns>
		Parameters GetParameters(IImageData data, IMatrixData inMatrix, ref string errString);
	}
}